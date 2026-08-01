using Duende.AccessTokenManagement;
using Duende.AccessTokenManagement.OpenIdConnect;
using Duende.IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Collections.Concurrent;
using AuthenticationToken = Ternary.HyRest.Identity.AuthenticationToken;

namespace Ternary.HyRest;

public class HylandTokenStore : IHylandTokenStore 
{
    private readonly HylandClientOptions _options;
    private readonly ILogger<HylandTokenStore> _logger;
    private ConcurrentDictionary<string, IOnBaseApp> _registrations { get; set; } = [];
    public HylandTokenStore(ILogger<HylandTokenStore> logger, IOptions<HylandOpenIdOptionsBuilder> optionsBuilder)
    {
        _logger = logger;
        _options = new HylandClientOptions();
        optionsBuilder.Value.OptionsAction(_options);
    }
    public async Task<IOnBaseApp> GetApp(HttpContext context) 
    {
        //string? accessToken = await context.GetTokenAsync("access_token");
        //if (accessToken != null &&_registrations.ContainsKey(accessToken) 
        //    && _registrations.TryGetValue(accessToken, out IOnBaseApp? app))
        //{
        //    return app.Init();
        //}
        throw new Exception("Could not retrieve app");
    }
    public async Task RegisterUser(TokenResult<UserToken> tokenResult)
    {
        if (tokenResult.FailedResult != null)
            throw new Exception("Failed to Authenticate");
        if (tokenResult.Token == null)
            throw new Exception("Token is null");
        var token = new AuthenticationToken()
        {
            AccessToken = tokenResult.Token.AccessToken,
            ExpiresIn = tokenResult.Token.Expiration.Subtract(DateTime.UtcNow).Minutes,
            Scope = tokenResult.Token.Scope.Value,
            TokenType = tokenResult.Token.AccessTokenType.Value
        };

        var client = new HttpClient();
        var disco = await client.GetDiscoveryDocumentAsync(_options.IdsBaseUrl);
        if (disco.IsError) throw new Exception(disco.Error);

        var response = await client.GetUserInfoAsync(new UserInfoRequest
        {
            Address = disco.UserInfoEndpoint,
            Token = tokenResult.Token.AccessToken
        });

        var username = response.Claims.FirstOrDefault(c => c.Type == "username");
        if (username == null)
            throw new Exception("Username is null");
        if (!_registrations.ContainsKey(token.AccessToken))
        {
            //if (!_registrations.TryAdd(username.Value, OnBaseApp.CreatePreAuthenticated(_options, _loggerFactory.CreateLogger<OnBaseApp>(), token)))
            //{
                throw new Exception("Couldn't register app");
            //}
        }
    }
}

public interface IHylandTokenStore
{
    //Task<IOnBaseApp> GetApp(HttpContext context);
    //Task RegisterUser(TokenResult<UserToken> tokenResult);
}
