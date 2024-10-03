using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContextRepository
{
    public interface ICompanyQueryRepository<T> : ICompanyRepository<T>, IQueryGenericRepository<T> where T : Entity
    {

    }
}
