using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Text.Encodings.Web;

namespace HyRest.DependencyInjection;

public class HylandAuthenticationHandler : OpenIdConnectHandler
{
    public HylandAuthenticationHandler(IOptionsMonitor<OpenIdConnectOptions> options,
        ILoggerFactory logger, UrlEncoder encoder, HtmlEncoder htmlEncoder)
        : base(options, logger, htmlEncoder, encoder) 
    {
        
    }
    protected override async Task HandleChallengeAsync(AuthenticationProperties properties)
    {
        await base.HandleChallengeAsync(properties);     
    }   
    protected override async Task<OpenIdConnectMessage> RedeemAuthorizationCodeAsync(OpenIdConnectMessage tokenEndpointRequest)
    {
        var message = await base.RedeemAuthorizationCodeAsync(tokenEndpointRequest);
        return message;
    }    
}
