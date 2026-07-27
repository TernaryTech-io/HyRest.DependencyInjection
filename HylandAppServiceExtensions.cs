using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ternary.HyRest.DependencyInjection;

public static class HylandAppServiceExtensions
{  
    public static IHostApplicationBuilder AddSingletonHylandApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
        Action<IAuthenticationCredentials, HylandClientOptions> optionsAction)
    {
        builder.Services.AddHylandApp(credentials, optionsAction);
        return builder;
    }
    public static IServiceCollection AddHylandApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, HylandClientOptions> optionsAction)
    {
        sc.Configure<HylandAppOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddSingleton<OnBaseApp>();
        return sc;
    }

    public static IHostApplicationBuilder AddScopedHylandApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
        Action<IAuthenticationCredentials, HylandClientOptions> optionsAction)
    {
        builder.Services.AddHylandScopedApp(credentials, optionsAction);
        return builder;
    }
    public static IServiceCollection AddHylandScopedApp(this IServiceCollection sc,
        IAuthenticationCredentials credentials, Action<IAuthenticationCredentials, HylandClientOptions> optionsAction)
    {
        sc.Configure<HylandAppOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
            options.Credentials = credentials;
        });
        sc.AddScoped<OnBaseScopedApp>();
        return sc;
    }

    public static IHostApplicationBuilder AddExternalAuthHylandApp(this IHostApplicationBuilder builder,
        Action<HylandClientOptions> optionsAction, Action<OpenIdConnectOptions> authOptions)
    {
        builder.Services.AddHylandApp(optionsAction, authOptions);
        return builder;
    }
    public static IServiceCollection AddHylandApp(this IServiceCollection sc, Action<HylandClientOptions> optionsAction, Action<OpenIdConnectOptions> authOptions)
    {
        sc.Configure<HylandOpenIdOptionsBuilder>((options) =>
        {
            options.OptionsAction = optionsAction;
        });        
        sc.AddSingleton<IOnBaseAppBuilder,OnBaseAppBuilder>();
        sc.AddHylandAuthentication(authOptions);        
        return sc;
    }
    public static AuthenticationBuilder AddHylandAuthentication(this IServiceCollection services, Action<OpenIdConnectOptions> authOptions)
        => services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddHylandConnect("HylandIdS", authOptions);

    public static AuthenticationBuilder AddHylandConnect(this AuthenticationBuilder builder, string authenticationScheme, Action<OpenIdConnectOptions> configureOptions)
    {
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IConfigureOptions<OpenIdConnectOptions>, HylandAuthConfigureOptions>());
        builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<IPostConfigureOptions<OpenIdConnectOptions>, OpenIdConnectPostConfigureOptions>());
        return builder.AddRemoteScheme<OpenIdConnectOptions, HylandAuthenticationHandler>(authenticationScheme, OpenIdConnectDefaults.DisplayName, configureOptions);
    }
}
