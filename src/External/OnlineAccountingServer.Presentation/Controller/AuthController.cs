﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login;
using OnlineAccountingServer.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Presentation.Controller
{
    public class AuthController : ApiController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginCommand request)
        {
            LoginCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
