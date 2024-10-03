using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.Abstractions;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.AppDbContextRepository;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.Repositories.GenericRepositories.AppDbContextRepository
{
    public class AppCommandRepository<T> : IAppCommandRepository<T> where T : Entity
    {
        private readonly AppDbContext _context;

        public AppCommandRepository(AppDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();

        }

        private static readonly Func<AppDbContext, string, Task<T>> GetByIdCompiled = EF.CompileAsyncQuery((AppDbContext context, string id) => context.Set<T>().FirstOrDefault(p => p.Id == id));

        public DbSet<T> Entity { get; set; }

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
