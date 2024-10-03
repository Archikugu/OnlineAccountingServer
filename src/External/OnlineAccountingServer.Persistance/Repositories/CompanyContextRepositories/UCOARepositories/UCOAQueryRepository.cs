using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.CompanyContextRepositories.UCOARepositories;
using OnlineAccountingServer.Persistance.Repositories.GenericRepositories.CompanyDbContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Persistance.Repositories.CompanyContextRepositories.UCOARepositories
{
    public sealed class UCOAQueryRepository : CompanyQueryRepository<UniformChartOfAccount>, IUCOAQueryRepository
    {
    }
}
