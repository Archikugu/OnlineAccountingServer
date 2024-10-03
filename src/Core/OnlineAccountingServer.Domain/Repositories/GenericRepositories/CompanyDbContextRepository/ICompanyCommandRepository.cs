using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContextRepository
{
    public interface ICompanyCommandRepository<T> : ICompanyRepository<T>, ICommandGenericRepository<T> where T : Entity
    {
    }
}
