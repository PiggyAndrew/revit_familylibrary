using Abp.Application.Services.Dto;
using Revit.Entity.Commons;
using Revit.Shared.Entity.Commons.Dto;
using Revit.Shared.Entity.Roles;

namespace Revit.Service.Roles
{
    public interface IRoleService
    {
       Task<RoleDto>  GetRole(long id);

       Task<ListResultDto<RoleDto>> GetListAsync(RolePageRequestDto rolePageRequestDto);
    }
}