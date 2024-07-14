
using OnlineAccountingServer.Application.Abstractions;
using OnlineAccountingServer.Infrastructure.Authentication;

namespace OnlineAccountingServer.WebAPI.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider, JwtProvider>();
        }
    }
}
