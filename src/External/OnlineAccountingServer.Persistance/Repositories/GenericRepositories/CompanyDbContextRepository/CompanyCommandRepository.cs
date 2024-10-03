using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstractions;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContextRepository;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Repositories.GenericRepositories.CompanyDbContextRepository
{
    public class CompanyCommandRepository<T> : ICompanyCommandRepository<T> where T : Entity
    {
        private static readonly Func<CompanyDbContext, string, Task<T>> GetByIdCompiled = EF.CompileAsyncQuery((CompanyDbContext context, string id) => context.Set<T>().FirstOrDefault(p => p.Id == id));

        private CompanyDbContext _context;

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
            Entity = _context.Set<T>();
        }
        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Entity.AddAsync(entity, cancellationToken);
        }

        public async Task AddRangeAsync(IEnumerable<T> entity, CancellationToken cancellationToken)
        {
            await Entity.AddRangeAsync(entity, cancellationToken);
        }

        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await GetByIdCompiled(_context, id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Entity.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            Entity.UpdateRange(entities);
        }
    }
}
