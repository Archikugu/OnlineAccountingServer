using MediatR;
using OnlineAccountingServer.Application.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed record UpdateRoleCommand(string Id, string Code, string Name) : ICommand<UpdateRoleCommandResponse>;
}
