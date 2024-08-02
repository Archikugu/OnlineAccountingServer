using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using OnlineAccountingServer.Domain.Roles;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
    public sealed class CreateAllRolesCommandHandler : ICommandHandler<CreateAllRolesCommand, CreateAllRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public CreateAllRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<CreateAllRolesCommandResponse> Handle(CreateAllRolesCommand request, CancellationToken cancellationToken)
        {
            IList<AppRole> originalRoleList= RoleList.GetStaticRoles();
            IList<AppRole> newRoleList= new List<AppRole>();

            foreach (AppRole role in originalRoleList)
            {
                AppRole checkRole = await _roleService.GetByCode(role.Code);
                if (checkRole == null) newRoleList.Add(role);
            }

            await _roleService.AddRangeAsync(newRoleList);
            return new();
        }
    }
}
