using Duende.AccessTokenManagement.OpenIdConnect;
using HyRest.Identity;
using HyRest.Identity.Credentials;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

namespace HyRest.DependencyInjection;

public static class HostApplicationBuilderExtensions
{
    public static IHostApplicationBuilder AddHylandApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
        Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        builder.Services.AddHylandApp(credentials, optionsAction);
        return builder;
    }
    public static IHostApplicationBuilder AddHylandScopedApp(this IHostApplicationBuilder builder, IAuthenticationCredentials credentials,
        Action<IAuthenticationCredentials, IHylandClientOptions> optionsAction)
    {
        builder.Services.AddHylandScopedApp(credentials, optionsAction);
        return builder;
    }
    public static IHostApplicationBuilder AddOpenIdHylandApp<T>(this IHostApplicationBuilder builder,
        Action<OpenIdCredentials> credentialAction, Action<IHylandClientOptions> optionsAction) where T : class, IOnBaseApp
    {

        var options = new HylandClientOptions();
        optionsAction(options);
        var credentials = new OpenIdCredentials();
        credentialAction(credentials);

        builder.Services.AddOpenIdHylandApp<T>(credentials, optionsAction, authOptions =>
        {
            authOptions.Authority = options.IdsBaseUrl;
            authOptions.ClientId = credentials.ClientId;
            authOptions.ClientSecret = credentials.ClientSecret;
            authOptions.CallbackPath = credentials.CallbackPath;
            authOptions.ResponseType = "code";
            authOptions.SignedOutCallbackPath = credentials.SignedOutCallbackPath;
            authOptions.SignedOutRedirectUri = credentials.SignedOutRedirectUri;
            authOptions.GetClaimsFromUserInfoEndpoint = true;
            authOptions.ResponseType = "code";
            authOptions.SaveTokens = true;
            authOptions.Scope.Clear();
            credentials.ScopeCollection.ToList().ForEach(s =>
            {
                authOptions.Scope.Add(s);
            });
        });
        
        builder.Services.AddTransient<SessionCookieClientHandler>();
        builder.Services.AddUserAccessTokenHttpClient<HylandOpenIdAuthClient>(null, (sp, client) =>
        {
            client.BaseAddress = new Uri(options.IdsBaseUrl);            
        });
        builder.Services.AddHttpClient<HylandApiClient>(client =>
        {
            client.BaseAddress = new Uri(options.ApiBaseUrl);
        })
        .ConfigurePrimaryHttpMessageHandler(sp => sp.GetRequiredService<SessionCookieClientHandler>())
        .AddUserAccessTokenHandler();
        return builder;
    }
}
