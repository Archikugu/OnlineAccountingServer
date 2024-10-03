using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContextRepository
{
    public interface IAppQueryRepository<T> : IQueryGenericRepository<T>, IRepository<T> where T : Entity
    {
    }
}
