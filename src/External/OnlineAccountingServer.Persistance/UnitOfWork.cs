using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Domain;
using OnlineAccountingServer.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private CompanyDbContext _context;
        public void SetDbContextInstance(DbContext context)
        {
            _context = (CompanyDbContext)context;
        }

        public async Task<int> SaveChangesAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count;
        }
    }
}
