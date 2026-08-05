using Duende.AccessTokenManagement.OpenIdConnect;
using HyRest.Identity.Credentials;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;

namespace HyRest.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHylandApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        sc.Configure<HylandClientOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddSingleton<OnBaseApp>();
        return sc;
    }

    public static IServiceCollection AddHylandScopedApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        sc.Configure<HylandClientOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddScoped<OnBaseScopedApp>();
        return sc;
    }

    public static IServiceCollection AddOpenIdHylandApp<T>(this IServiceCollection sc, OpenIdCredentials credentials, Action<IHylandClientOptions> optionsAction,
        Action<OpenIdConnectOptions> authOptions) where T : class, IOnBaseApp
    {
        sc.Configure<HylandOpenIdClientOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
        });
        sc.AddHylandAuthentication(authOptions);
        sc.AddOpenIdConnectAccessTokenManagement();
        sc.AddAuthorization();
        sc.AddSingleton<IHylandClientFactory, HylandClientFactory>( sp =>
        {
            return new HylandClientFactory(sp, credentials, sp.GetRequiredService<IHttpContextAccessor>());
        });
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
}
