using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Rol Bulunamadı!");
            await _roleService.DeleteAsync(role);
            return new();
        }
    }
}
