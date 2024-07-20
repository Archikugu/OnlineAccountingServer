using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.UCOARepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance.Repositories.UCOARepositories
{
    public sealed class UCOAQueryRepository : QueryRepository<UniformChartOfAccount>, IUCOAQueryRepository
    {
    }
}
