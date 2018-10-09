using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.Options;
 
namespace Pelijuttujentaustat.Middleware
{
    public class Auth
    {
        private readonly RequestDelegate _next;
        private readonly IOptions<SecuritySettings> _security;
 
        public Auth(RequestDelegate next, IOptions<SecuritySettings> security)
        {
            _next = next;
            _security = security;
        }
    
        public async Task Invoke(HttpContext context)
        {
            StringValues key;
            context.Request.Headers.TryGetValue("x-api-key", out key);
 
            if (key == _security.Value.AdminApiKey)
            {
                var claimsIdentity = (ClaimsIdentity) context.User.Identity;
                claimsIdentity.AddClaim(new Claim("Admin", "Admin"));
                await _next.Invoke(context);
            }
            else if (key == _security.Value.ApiKey)
            {
                await _next.Invoke(context);
            }
            else if (key == "")
            {
                context.Response.StatusCode = 400;
            }
            else
            {
                context.Response.StatusCode = 403;
            }
        }
    }
 
    public static class AuthMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Auth>();
        }
    }
}