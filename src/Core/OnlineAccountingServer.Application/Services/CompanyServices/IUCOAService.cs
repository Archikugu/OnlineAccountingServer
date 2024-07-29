using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using OnlineAccountingServer.Domain.CompanyEntities;

namespace OnlineAccountingServer.Application.Services.CompanyServices
{
    public interface IUCOAService
    {
        Task CreateUCOAAsync(CreateUCOACommand request, CancellationToken cancellationToken);

        Task<UniformChartOfAccount> GetByCode(string code);
    }
}
