using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Permissions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        Task<List<PermissionDto>> GetAllPermissions();
    }
}
