using MediatR;
using OnlineAccountingServer.Application.Services.CompanyServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA
{
    public sealed class CreateUCOAHandler : IRequestHandler<CreateUCOARequest, CreateUCOAResponse>
    {
        private readonly IUCOAService _ucoaService;

        public CreateUCOAHandler(IUCOAService ucoaService)
        {
            _ucoaService = ucoaService;
        }

        public async Task<CreateUCOAResponse> Handle(CreateUCOARequest request, CancellationToken cancellationToken)
        {
            await _ucoaService.CreateUCOAAsync(request);
            return new();
        }
    }
}
