using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller
{
    public sealed class UCOAsController : ApiController
    {
        public UCOAsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUCOA(CreateUCOACommand request, CancellationToken cancellationToken)
        {
            CreateUCOACommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}
