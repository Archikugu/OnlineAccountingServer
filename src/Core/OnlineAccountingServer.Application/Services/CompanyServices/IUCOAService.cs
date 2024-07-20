using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;

namespace OnlineAccountingServer.Application.Services.CompanyServices
{
    public interface IUCOAService
    {
        Task CreateUCOAAsync(CreateUCOACommand request, CancellationToken cancellationToken);
    }
}
