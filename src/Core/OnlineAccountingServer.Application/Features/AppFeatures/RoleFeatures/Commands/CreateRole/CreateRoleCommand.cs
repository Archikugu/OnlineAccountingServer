using OnlineAccountingServer.Application.Messaging;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(string Code, string Name) : ICommand<CreateRoleCommandResponse>;
}
