using OnlineAccountingServer.Application.Messaging;
namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed record DeleteRoleCommand(string Id) : ICommand<DeleteRoleCommandResponse>;
}
