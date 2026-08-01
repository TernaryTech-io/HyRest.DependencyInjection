using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System.Reflection.PortableExecutable;

namespace HyRest.DependencyInjection;

public class HylandAuthOptions : OpenIdConnectOptions
{
    public HylandAuthOptions() : base()
    {        
        GetClaimsFromUserInfoEndpoint = true;
        ResponseType = "code";
        SaveTokens = true;
        Scope.Clear();
        Scope.Add("openid");
        Scope.Add("profile");
        Scope.Add("profile.onbase");
        Scope.Add("evolution");        
    }
}