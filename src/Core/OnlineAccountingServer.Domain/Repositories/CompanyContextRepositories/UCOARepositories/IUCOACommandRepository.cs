using OnlineAccountingServer.Domain.CompanyEntities;
using OnlineAccountingServer.Domain.Repositories.GenericRepositories.CompanyDbContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Domain.Repositories.CompanyContextRepositories.UCOARepositories
{
    public interface IUCOACommandRepository : ICompanyCommandRepository<UniformChartOfAccount>
    {
    }
}
