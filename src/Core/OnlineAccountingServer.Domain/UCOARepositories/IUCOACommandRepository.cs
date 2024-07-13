using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Domain.UCOARepositories
{
    public interface IUCOACommandRepository : ICommandRepository<UniformChartOfAccount>
    {
    }
}
