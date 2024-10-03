using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain.UnitOfWorks;
using OnlineAccountingServer.Persistance.Context;

namespace OnlineAccountingServer.Persistance.UnitOfWorks
{
    public sealed class CompanyUnitOfWork : ICompanyUnitOfWork
    {
        private CompanyDbContext _context;
        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
