using Duende.AccessTokenManagement.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System.Net;
using Ternary.HyRest.Identity;

namespace Ternary.HyRest.DependencyInjection;

public static class HylandAppServiceExtensions
{  
    public static IHostApplicationBuilder AddSingletonHylandApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
        Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        builder.Services.AddHylandApp(credentials, optionsAction);
        return builder;
    }
    public static IServiceCollection AddHylandApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        sc.Configure<HylandAppOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddSingleton<OnBaseApp>();
        return sc;
    }

    //public static IHostApplicationBuilder AddScopedHylandApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
    //    Action<IAuthenticationCredentials, HylandClientOptions> optionsAction)
    //{
    //    builder.Services.AddHylandScopedApp(credentials, optionsAction);
    //    return builder;
    //}
    //public static IServiceCollection AddHylandScopedApp(this IServiceCollection sc,
    //    IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, HylandClientOptions> optionsAction)
    //{
    //    sc.Configure<HylandAppOptionsBuilder>((options) =>
    //    {
    //        options.OptionsAction = optionsAction;
    //        options.Credentials = credentials;
    //    });
    //    sc.AddScoped<OnBaseScopedApp>();
    //    return sc;
    //}

    public static IHostApplicationBuilder AddExternalAuthHylandApp(this IHostApplicationBuilder builder,
        Action<IHylandClientOptions> optionsAction, Action<OpenIdConnectOptions> authOptions)
    {
        builder.Services.AddHylandApp(optionsAction, authOptions);
        var options = new HylandClientOptions();        
        optionsAction(options);
        builder.Services.AddTransient<LicenseHeaderHandler>();
        builder.Services.AddTransient<SessionCookieClientHandler>();
        var cookiecontainer = new CookieContainer();
        builder.Services.AddSingleton(cookiecontainer);
        builder.Services.AddHttpClient<HylandApiClient>(client =>
        {
            client.BaseAddress = new Uri(options.ApiBaseUrl);
        })
        .ConfigurePrimaryHttpMessageHandler<SessionCookieClientHandler>()
        .AddHttpMessageHandler<LicenseHeaderHandler>()
        .AddUserAccessTokenHandler();
        return builder;
    }
    public static IServiceCollection AddHylandApp(this IServiceCollection sc, Action<IHylandClientOptions> optionsAction, Action<OpenIdConnectOptions> authOptions)
    {
        sc.Configure<HylandOpenIdOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
        });  
        sc.AddHylandAuthentication(authOptions);
        sc.AddOpenIdConnectAccessTokenManagement();
        sc.AddAuthorization();
        sc.AddSingleton<IHylandClientFactory,HylandClientFactory>();
        sc.AddSingleton<OnBaseApp>();
        return sc;
    }
    public static AuthenticationBuilder AddHylandAuthentication(this IServiceCollection services, Action<OpenIdConnectOptions> authOptions)
        => services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)        
        .AddCookie(options =>
        {

            options.Cookie.Name = CookieAuthenticationDefaults.AuthenticationScheme;
            options.Events.OnSigningOut = async e => { await e.HttpContext.RevokeRefreshTokenAsync(); };
        })
        .AddHylandConnect("HylandIdS", authOptions);

    public static AuthenticationBuilder AddHylandConnect(this AuthenticationBuilder builder, string authenticationScheme, Action<OpenIdConnectOptions> configureOptions)
    {
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IConfigureOptions<OpenIdConnectOptions>, HylandAuthConfigureOptions>());
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<OpenIdConnectOptions>, OpenIdConnectPostConfigureOptions>());
        
        return builder.AddRemoteScheme<OpenIdConnectOptions, HylandAuthenticationHandler>(authenticationScheme, OpenIdConnectDefaults.DisplayName, configureOptions);
    }

    public static WebApplication UseHylandAuthentication(this WebApplication web, string basePath = "/user")
    {
        web.UseAuthentication();
        web.UseAuthorization();
        web.MapGet($"{basePath}/login", (string? returnUrl, HttpContext context) =>
        {
            var redirectUrl = returnUrl;
            var properties = new AuthenticationProperties
            {
                RedirectUri = $"{basePath}/authorized",
            };
            return Results.Challenge(properties, new[] { "HylandIdS" });
        });

        web.MapGet($"{basePath}/logout", async (HttpContext ctx) =>
        {
            await ctx.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await ctx.SignOutAsync("HylandIdS",
                new AuthenticationProperties { RedirectUri = "/" });
        });

        // Simple endpoint to confirm auth worked / inspect claims
        web.MapGet($"{basePath}/authorized", async (HttpContext ctx) =>
        {
            if (ctx.User?.Identity?.IsAuthenticated != true)
                return Results.Unauthorized();
            return Results.Ok($"Authentication Successful. You can close this window.");
        }).RequireAuthorization();
        web.MapGet($"{basePath}/unauthorized", (HttpContext ctx) =>
        {
            return Results.Ok("You have been logged out.");
        });
        return web;
    }
}
