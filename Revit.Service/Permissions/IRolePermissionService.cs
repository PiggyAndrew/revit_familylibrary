using Revit.Shared.Entity.Accounts;
using Revit.Shared.Entity.Accounts.DTO;
using Revit.Shared.Entity.Permissions;

namespace Revit.Service.Permissions
{
    public interface IRolePermissionService
    {
        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        List<AccountPermissionsDto> GetRolePermissions(string roleName);

        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        List<PermissionDto> GetRolePermissions(long roleId);

        /// <summary>
        /// 保存角色的权限列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="permissionIds"></param>
        /// <param name="CreatorId"></param>
        /// <returns></returns>
        bool SavePermissions(long roleId, List<long> permissionIds, long creatorId);
    }
}