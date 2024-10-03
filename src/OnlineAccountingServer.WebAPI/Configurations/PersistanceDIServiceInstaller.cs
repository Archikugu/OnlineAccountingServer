
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Persistance.Services.AppServices;
using OnlineAccountingServer.Persistance.Services.CompanyServices;
using OnlineAccountingServer.Persistance;
using OnlineAccountingServer.Domain.Repositories.CompanyContextRepositories.UCOARepositories;
using OnlineAccountingServer.Persistance.Repositories.CompanyContextRepositories.UCOARepositories;
using OnlineAccountingServer.Domain.Repositories.AppDbContextRepositories.CompanyRepositories;
using OnlineAccountingServer.Persistance.Repositories.AppDbContextRepositories.CompanyRepositories;
using OnlineAccountingServer.Domain.UnitOfWorks;
using OnlineAccountingServer.Persistance.UnitOfWorks;

namespace OnlineAccountingServer.WebAPI.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<ICompanyUnitOfWork, CompanyUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUCOAService, UCOAService>();
            services.AddScoped<IRoleService, RoleService>();
            #endregion

            #region Repositories
            services.AddScoped<IUCOACommandRepository, UCOACommandRepository>();
            services.AddScoped<IUCOAQueryRepository, UCOAQueryRepository>();

            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            #endregion

        }
    }
}
