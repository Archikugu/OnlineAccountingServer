using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContextRepository
{
    public interface IAppCommandRepository<T> : ICommandGenericRepository<T>, IRepository<T> where T : Entity
    {

    }
}
