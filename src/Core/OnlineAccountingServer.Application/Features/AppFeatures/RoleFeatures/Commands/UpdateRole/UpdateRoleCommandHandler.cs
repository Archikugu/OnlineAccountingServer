﻿using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleCommandHandler : ICommandHandler<UpdateRoleCommand, UpdateRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public UpdateRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<UpdateRoleCommandResponse> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Role Bulunamadı!");

            if (role.Code != request.Code)
            {
                AppRole checkCode = await _roleService.GetByCode(request.Code);
                if (checkCode != null) throw new Exception("Bu Kod Daha Önce Kaydedilmiş!");
            }

            role.Code = request.Code;
            role.Name = request.Name;

            await _roleService.UpdateAsync(role);
            return new();

        }
    }
}
