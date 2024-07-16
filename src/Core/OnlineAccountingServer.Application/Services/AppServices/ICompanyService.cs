using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Domain.AppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Services.AppServices
{
    public interface ICompanyService
    {
        Task CreateCompany(CreateCompanyCommand request);
        Task MigrateCompanyDatabases();
        Task<Company?> GetCompanyByName(string name);
    }
}
