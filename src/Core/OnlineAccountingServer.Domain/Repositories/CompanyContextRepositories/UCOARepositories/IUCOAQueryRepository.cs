using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContextRepository;

namespace OnlineAccountingServer.Domain.Repositories.CompanyContextRepositories.UCOARepositories
{
    public interface IUCOAQueryRepository : ICompanyQueryRepository<UniformChartOfAccount>
    {

    }
}
