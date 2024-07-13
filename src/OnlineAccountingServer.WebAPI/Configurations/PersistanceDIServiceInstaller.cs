
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Domain.UCOARepositories;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Persistance.Repositories.UCOARepositories;
using OnlineAccountingServer.Persistance.Services.AppServices;
using OnlineAccountingServer.Persistance.Services.CompanyServices;
using OnlineAccountingServer.Persistance;

namespace OnlineAccountingServer.WebAPI.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUCOAService, UCOAService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCOACommandRepository, UCOACommandRepository>();
            services.AddScoped<IUCOAQueryRepository, UCOAQueryRepository>();
            #endregion

        }
    }
}
