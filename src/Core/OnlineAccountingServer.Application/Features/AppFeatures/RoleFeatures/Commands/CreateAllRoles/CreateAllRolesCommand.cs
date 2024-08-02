using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
    public sealed record CreateAllRolesCommand() : ICommand<CreateAllRolesCommandResponse>;
}
