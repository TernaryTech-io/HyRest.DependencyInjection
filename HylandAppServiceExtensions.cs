using Duende.AccessTokenManagement.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HyRest.DependencyInjection;

public static class HylandAppServiceExtensions
{
    
    public static IHostApplicationBuilder AddHylandApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
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

    public static IHostApplicationBuilder AddHylandScopedApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
        Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        builder.Services.AddHylandScopedApp(credentials, optionsAction);
        return builder;
    }
    public static IServiceCollection AddHylandScopedApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        sc.Configure<HylandAppOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddScoped<OnBaseScopedApp>();
        return sc;
    }
    public static IHostApplicationBuilder AddOpenIdHylandApp<T>(this IHostApplicationBuilder builder,
        Action<IHylandClientOptions> optionsAction, Action<OpenIdConnectOptions> authOptions) where T : class, IOnBaseApp
    {
        builder.Services.AddOpenIdHylandApp<T>(optionsAction, authOptions);
        var options = new HylandClientOptions();        
        optionsAction(options);
        builder.Services.AddTransient<SessionCookieClientHandler>();
        builder.Services.AddUserAccessTokenHttpClient<HylandApiClient>(null, (sp, client) =>
        {
            client.BaseAddress = new Uri(options.ApiBaseUrl);
        });
        builder.Services.AddHttpClient<HylandApiClient>(client =>
        {
            client.BaseAddress = new Uri(options.ApiBaseUrl);
        })
        .ConfigurePrimaryHttpMessageHandler(sp => sp.GetRequiredService<SessionCookieClientHandler>())
        .AddUserAccessTokenHandler();
        return builder;
    }
    public static IServiceCollection AddOpenIdHylandApp<T>(this IServiceCollection sc, Action<IHylandClientOptions> optionsAction, 
        Action<OpenIdConnectOptions> authOptions) where T : class, IOnBaseApp
    {
        sc.Configure<HylandOpenIdOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
        });
        sc.AddHylandAuthentication(authOptions);
        sc.AddOpenIdConnectAccessTokenManagement();
        sc.AddAuthorization();
        sc.AddSingleton<IHylandClientFactory,HylandClientFactory>();
        if (typeof(T) == typeof(OnBaseApp))
            sc.AddSingleton<OnBaseApp>();
        else
            sc.AddScoped<OnBaseScopedApp>();
        return sc;
    }
    public static AuthenticationBuilder AddHylandAuthentication(this IServiceCollection services, Action<OpenIdConnectOptions> authOptions)
        => services.AddAuthentication(HylandAuthenticationDefaults.DefaultCookieScheme)        
        .AddCookie(options =>
        {
            options.Cookie.Name = HylandAuthenticationDefaults.DefaultCookieScheme;
            options.Events.OnSigningOut = async e => { await e.HttpContext.RevokeRefreshTokenAsync(); };
        })
        .AddOpenIdConnect(HylandAuthenticationDefaults.AuthenticationScheme, authOptions);
    public static OnBaseApp GetOnBaseApp(this IHost host)
        => host.Services.GetRequiredService<OnBaseApp>();
    public static OnBaseScopedApp GetOnBaseScopedApp(this IHost host)
    {
        var scope = host.Services.CreateAsyncScope();
        return scope.ServiceProvider.GetRequiredService<OnBaseScopedApp>();
    }
    public static WebApplication UseHylandAuthentication(this WebApplication web)
    {
        web.UseAuthentication();
        web.UseAuthorization();
        web.MapGet($"account/login", (string? returnUrl, HttpContext context) =>
        {
            var redirectUrl = returnUrl;
            var properties = new AuthenticationProperties
            {
                RedirectUri = $"/account/authorized",
            };
            return Results.Challenge(properties, new[] { HylandAuthenticationDefaults.AuthenticationScheme });
        });

        web.MapGet($"account/logout", async (HttpContext ctx) =>
        {
            await ctx.SignOutAsync(HylandAuthenticationDefaults.AuthenticationScheme);
            await ctx.SignOutAsync(HylandAuthenticationDefaults.AuthenticationScheme,
                new AuthenticationProperties { RedirectUri = "/" });
        });
        web.MapGet($"account/authorized", async (HttpContext ctx) =>
        {
            if (ctx.User?.Identity?.IsAuthenticated != true)
                return Results.Unauthorized();
            return Results.Ok($"Authentication Successful. You can close this window.");
        }).RequireAuthorization();  
        return web;
    }
}
