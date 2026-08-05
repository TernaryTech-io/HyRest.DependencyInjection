using Duende.AccessTokenManagement.OpenIdConnect;
using Duende.IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HyRest.DependencyInjection;

public static class HylandAppServiceExtensions
{       
    public static WebApplication UseHylandAuthentication(this WebApplication web)
    {
        web.UseAuthentication();
        web.UseAuthorization();
        web.MapGet($"account/login", (HttpContext context) =>
        {            
            var properties = new AuthenticationProperties
            {
                RedirectUri = $"/account/authorized",
            };
            return Results.Challenge(properties, new[] { HylandAuthenticationDefaults.AuthenticationScheme });
        });

        web.MapGet($"account/logout", async (HttpContext context) =>
        {
            //await context.SignOutAsync(HylandAuthenticationDefaults.AuthenticationScheme);
            await context.SignOutAsync(HylandAuthenticationDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = "/" });
        });
        web.MapGet($"account/authorized", async (HttpContext context) =>
        {
            if (context.User?.Identity?.IsAuthenticated != true)
                return Results.Unauthorized();
            var client = web.Services.GetRequiredService<HylandApiClient>(); 
            var token = await context.GetUserAccessTokenAsync();
            var disco = await client.HttpClient.GetDiscoveryDocumentAsync("https://onbase.ternarytech.io/auth");
            var user = await client.HttpClient.GetUserInfoAsync(new UserInfoRequest
            {
                Address = disco.UserInfoEndpoint,
                Token = token.Token.AccessToken
            });
            user.Claims.ToList().ForEach(c =>
            {
                Console.WriteLine(c);
            });
            return Results.Ok($"Authentication Successful. You can close this window.");
        }).RequireAuthorization();  
        return web;
    }
}
