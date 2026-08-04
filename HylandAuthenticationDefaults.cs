using Microsoft.AspNetCore.Authentication.Cookies;

namespace HyRest.DependencyInjection;

public class HylandAuthenticationDefaults
{
    public const string AuthenticationScheme = "HylandIdS";
   
    public const string DefaultCookieScheme = "Cookies";
}
