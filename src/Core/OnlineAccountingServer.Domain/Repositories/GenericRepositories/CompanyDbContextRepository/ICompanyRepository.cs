using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstractions;

namespace OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContextRepository
{
    public interface ICompanyRepository<T> : IRepository<T> where T : Entity
    {
        void SetDbContextInstance(DbContext context);
    }
}
