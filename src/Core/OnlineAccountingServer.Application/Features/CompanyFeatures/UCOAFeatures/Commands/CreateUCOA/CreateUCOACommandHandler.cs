using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.CompanyServices;
using OnlineAccountingServer.Domain.CompanyEntities;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA
{
    public sealed class CreateUCOACommandHandler : ICommandHandler<CreateUCOACommand, CreateUCOACommandResponse>
    {
        private readonly IUCOAService _ucoaService;

        public CreateUCOACommandHandler(IUCOAService ucoaService)
        {
            _ucoaService = ucoaService;
        }

        public async Task<CreateUCOACommandResponse> Handle(CreateUCOACommand request, CancellationToken cancellationToken)
        {
            UniformChartOfAccount uniformChartOfAccount = await _ucoaService.GetByCode(request.Code);
            if (uniformChartOfAccount != null) throw new Exception("Bu hesap planı kodu daha önce tanımlanmış");

            await _ucoaService.CreateUCOAAsync(request, cancellationToken);
            return new();
        }
    }
}
