using OnlineAccountingServer.Domain.AppEntities;
using OnlineAccountingServer.Domain.Repositories.AppDbContextRepositories.CompanyRepositories;
using OnlineAccountingServer.Persistance.Context;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContextRepository;

namespace OnlineAccountingServer.Persistance.Repositories.AppDbContextRepositories.CompanyRepositories
{
    public sealed class CompanyCommandRepository : AppCommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
