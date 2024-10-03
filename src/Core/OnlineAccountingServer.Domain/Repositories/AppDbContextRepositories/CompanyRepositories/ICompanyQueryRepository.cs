using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContextRepository;

namespace OnlineAccountingServer.Domain.Repositories.AppDbContextRepositories.CompanyRepositories
{
    public interface ICompanyQueryRepository : IAppQueryRepository<Company>
    {
    }
}
