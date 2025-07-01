using Microsoft.Extensions.Options;
using Project.DAL.Configuration;

namespace Proect.API.Extensions
{
    public static class HttpContextExtensions
    {
        public static void AppendTokenToCookie(this HttpContext context, string token, IOptions<JwtConfiguration> options)
        {
            var _jwtConfiguration = options.Value;

            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None, // Required for cross-domain cookies
                Domain = ".localhost", // Allows cookies for all subdomains
                Expires = DateTime.UtcNow.AddMinutes(_jwtConfiguration.AccessTokenLifetime)
            };

            context.Response.Cookies.Append("AuthToken", token, cookieOptions);
        }
    }
}
