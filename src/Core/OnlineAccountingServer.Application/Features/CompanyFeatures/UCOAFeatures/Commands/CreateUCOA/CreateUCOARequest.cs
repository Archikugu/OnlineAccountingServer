using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.CompanyFeatures.UCOAFeatures.Commands.CreateUCOA
{
    public sealed class CreateUCOARequest :IRequest<CreateUCOAResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string CompanyId { get; set; }
    }
}
