using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories
{
    public interface IRepository<T> where T : Entity
    {
        DbSet<T> Entity { get; set; }

    }
}
