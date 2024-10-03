using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Domain.UnitOfWorks
{
    public interface ICompanyUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
    }
}
