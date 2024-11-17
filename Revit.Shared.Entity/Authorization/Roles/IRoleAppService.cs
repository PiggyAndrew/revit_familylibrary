using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Permissions;
using Revit.Shared.Entity.Roles;

namespace Revit.Shared.Entity.Authorization.Roles
{
    /// <summary>
    /// Application service that is used by 'role management' page.
    /// </summary>
    public interface IRoleAppService : IApplicationService
    {
        Task<ListResultDto<RoleDto>> GetListAsync(RolePageRequestDto request);

        Task<GetRoleForEditOutput> GetRole(long? input);

        Task DeleteRole(EntityDto input);

        Task<List<PermissionDto>> GetRolePermissions(long id);

        Task<RoleCreateDto> PostRole(RoleCreateDto role);
    }
}