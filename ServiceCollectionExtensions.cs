using Duende.AccessTokenManagement.OpenIdConnect;
using HyRest.Cache;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Hybrid;

namespace HyRest.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddHylandApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        sc.RegisterHylandCacheServices();
        sc.Configure<HylandClientOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddSingleton<OnBaseAppBuilder>();
        sc.AddSingleton<OnBaseApp>(sp =>
        {
            var builder = sp.GetRequiredService<OnBaseAppBuilder>();
            return builder.Build();
        });
        return sc;
    }

    public static IServiceCollection AddHylandScopedApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        sc.RegisterHylandCacheServices();
        sc.Configure<HylandClientOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddSingleton<OnBaseAppBuilder>();
        sc.AddScoped<OnBaseScopedApp>(sp =>
        {
            var builder = sp.GetRequiredService<OnBaseAppBuilder>();
            return builder.BuildScoped();
        });
        return sc;
    }
    internal static IServiceCollection RegisterHylandCacheServices(this IServiceCollection sc)
    {
        sc.AddHybridCache(options =>
        {
            options.DefaultEntryOptions = new HybridCacheEntryOptions
            {
                Expiration = TimeSpan.FromHours(12),
                LocalCacheExpiration = TimeSpan.FromMinutes(60),
            };
        });
        sc.AddSingleton<OnBaseAppCache>();
        return sc;
    }

    public static IServiceCollection AddOpenIdHylandApp<T>(this IServiceCollection sc, HylandClientOptions options, OpenIdCredentials credentials,
        Action<OpenIdConnectOptions> authOptions) where T : class, IOnBaseApp
    {
        sc.RegisterHylandCacheServices();        
        sc.AddHylandAuthentication(authOptions);
        sc.AddOpenIdConnectAccessTokenManagement();
        sc.AddAuthorization();
        sc.AddHttpContextAccessor();
        sc.AddSingleton( sp =>
        {
            return new HylandClientFactory(sp, credentials, sp.GetRequiredService<IHttpContextAccessor>());
        });
        OnBaseAppBuilder.RegisterAppServices<T>(sc,options);
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
