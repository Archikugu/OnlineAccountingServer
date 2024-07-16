using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineAccountingServer.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabases;
using OnlineAccountingServer.Presentation.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Presentation.Controller
{
    public class CompaniesController : ApiController
    {
        public CompaniesController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MigrateCompanyDatabasesCommand request = new();
            MigrateCompanyDatabasesCommandResponse response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
