
using Microsoft.AspNetCore.Authentication.JwtBearer;
using OnlineAccountingServer.WebAPI.OptionsSetup;

namespace OnlineAccountingServer.WebAPI.Configurations
{
    public class AuthenticationAndAuthorizationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionsSetup>();

            services.ConfigureOptions<JwtBearerOptionsSetup>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
        }
    }
}
