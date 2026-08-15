using Duende.AccessTokenManagement.OpenIdConnect;

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
        builder.Services.AddSingleton(options);
        var credentials = new OpenIdCredentials();
        credentialAction(credentials);

        builder.Services.AddOpenIdHylandApp<T>(credentials, authOptions =>
        {
            authOptions.Authority = options.IdsBaseUrl;
            authOptions.ClientId = credentials.ClientId;
            authOptions.ClientSecret = credentials.ClientSecret;
            authOptions.CallbackPath = credentials.CallbackPath;
            authOptions.ResponseType = "code";
            authOptions.SignedOutCallbackPath = credentials.SignedOutCallbackPath;
            authOptions.SignedOutRedirectUri = credentials.SignedOutRedirectUri;
            authOptions.GetClaimsFromUserInfoEndpoint = true; 
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
