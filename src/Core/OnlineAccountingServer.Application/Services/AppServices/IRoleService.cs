using OnlineAccountingServer.Application.Features.RoleFeatures.Commands.CreateRole;
using OnlineAccountingServer.Application.Features.RoleFeatures.Commands.DeleteRole;
using OnlineAccountingServer.Application.Features.RoleFeatures.Commands.UpdateRole;
using OnlineAccountingServer.Domain.AppEntities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAccountingServer.Application.Services.AppServices
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleRequest request);
        Task UpdateAsync(AppRole appRole);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetById(string id);
        Task<AppRole> GetByCode(string code);
        
    }
}
