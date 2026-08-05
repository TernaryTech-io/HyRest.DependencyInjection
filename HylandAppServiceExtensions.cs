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
            return Results.Ok($"Authentication Successful. You can close this window.");
        }).RequireAuthorization();  
        return web;
    }
}
