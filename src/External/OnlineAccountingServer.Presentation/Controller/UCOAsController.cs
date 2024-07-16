using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA;
using OnlineAccountingServer.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Presentation.Controller
{
    public sealed class UCOAsController : ApiController
    {
        public UCOAsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateUCOA(CreateUCOACommand request)
        {
            CreateUCOACommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

    }
}
