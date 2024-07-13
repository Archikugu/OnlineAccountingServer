using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.UCOARepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance.Repositories.UCOARepositories
{
    public sealed class UCOACommandRepository : CommandRepository<UniformChartOfAccount>, IUCOACommandRepository
    {
    }
}
