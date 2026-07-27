using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Text.Encodings.Web;

namespace Ternary.HyRest.DependencyInjection;

public class HylandAuthenticationHandler : OpenIdConnectHandler
{
    private readonly IOnBaseAppBuilder _appBuilder;

    public HylandAuthenticationHandler(IOnBaseAppBuilder appBuilder, IOptionsMonitor<OpenIdConnectOptions> options,
        ILoggerFactory logger, UrlEncoder encoder, HtmlEncoder htmlEncoder)
        : base(options, logger, htmlEncoder, encoder) 
    {
        _appBuilder = appBuilder;
    }
    protected override async Task HandleChallengeAsync(AuthenticationProperties properties)
    {
        await base.HandleChallengeAsync(properties);     
    }
    protected override async Task<OpenIdConnectMessage> RedeemAuthorizationCodeAsync(OpenIdConnectMessage tokenEndpointRequest)
    {
        var message = await base.RedeemAuthorizationCodeAsync(tokenEndpointRequest);
        _appBuilder.RegisterUserApp(message);
        return message;
    }    
}
