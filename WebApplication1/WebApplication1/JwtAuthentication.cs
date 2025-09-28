using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;

namespace WebApplication1
{
    public static class JwtAuthentication
    {
        public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration) {
            services.Configure<JwtBearerOptions>("Bearer", configuration.GetSection("JwtBearerOptions"));
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer();
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
        }
    }
}
