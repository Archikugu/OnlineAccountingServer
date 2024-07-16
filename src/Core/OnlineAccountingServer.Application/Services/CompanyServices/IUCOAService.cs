using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Services.CompanyServices
{
    public interface IUCOAService
    {
        Task CreateUCOAAsync(CreateUCOACommand request);
    }
}
