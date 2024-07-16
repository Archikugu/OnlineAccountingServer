using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.CompanyServices;

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
            await _ucoaService.CreateUCOAAsync(request);
            return new();
        }
    }
}
