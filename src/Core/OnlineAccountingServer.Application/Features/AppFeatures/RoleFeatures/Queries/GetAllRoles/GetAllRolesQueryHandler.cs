using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineAccountingServer.Application.Messaging;
using OnlineAccountingServer.Application.Services.AppServices;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRolesQueryHandler : IQueryHandler<GetAllRolesQuery, GetAllRolesQueryResponse>
    {
        private readonly IRoleService _roleService;

        public GetAllRolesQueryHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetAllRolesQueryResponse> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAsync();
            return new GetAllRolesQueryResponse(roles);
        }
    }
}
