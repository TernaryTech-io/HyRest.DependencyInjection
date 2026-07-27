using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using AuthenticationToken = Ternary.HyRest.Identity.AuthenticationToken;
using System.Collections.Concurrent;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;

namespace Ternary.HyRest;

public class OnBaseAppBuilder : IOnBaseAppBuilder 
{
    private readonly HylandClientOptions _options;
    private readonly ILoggerFactory _loggerFactory;
    private readonly ILogger<OnBaseAppBuilder> _logger;
    private ConcurrentDictionary<string, IOnBaseApp> _registrations { get; set; } = [];
    public OnBaseAppBuilder(ILoggerFactory logFactory, IOptions<HylandOpenIdOptionsBuilder> optionsBuilder)
    {
        _loggerFactory = logFactory;
        _logger = _loggerFactory.CreateLogger<OnBaseAppBuilder>();
        _options = new HylandClientOptions();
        optionsBuilder.Value.OptionsAction(_options);
    }
    public async Task<IOnBaseApp> GetApp(HttpContext context) 
    {
        string? accessToken = await context.GetTokenAsync("access_token");
        if (accessToken != null &&_registrations.ContainsKey(accessToken) 
            && _registrations.TryGetValue(accessToken, out IOnBaseApp? app))
        {
            return app.Init();
        }
        throw new Exception("Could not retrieve app");
    }
    public void RegisterUserApp(OpenIdConnectMessage message)
    {
        var token = new AuthenticationToken()
        {
            AccessToken = message.AccessToken,
            ExpiresIn = int.Parse(message.ExpiresIn),
            Scope = message.Scope,
            TokenType = message.TokenType
        };

        if (!_registrations.ContainsKey(token.AccessToken))
        {
            if (!_registrations.TryAdd(token.AccessToken, OnBaseApp.CreatePreAuthenticated(_options, _loggerFactory.CreateLogger<OnBaseApp>(), token)))
            {
                throw new Exception("Couldn't register app");
            }
        }
    }
}

public interface IOnBaseAppBuilder
{
    Task<IOnBaseApp> GetApp(HttpContext context);
    void RegisterUserApp(OpenIdConnectMessage message);
}