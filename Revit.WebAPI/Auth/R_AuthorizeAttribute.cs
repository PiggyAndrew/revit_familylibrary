using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Revit.Service.Permissions;
using Revit.Service.Users;
using Revit.Shared.Entity.Accounts;
using System.Text.RegularExpressions;
using Revit.Shared.Entity.Accounts.DTO;

namespace Revit.WebAPI.Auth
{
    /// <summary>
    /// 定义权限的Attribute
    /// </summary>
    public class R_AuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {




        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var userName = context.HttpContext.User.Identity?.Name;
            var userRepository = context.HttpContext.RequestServices.GetService(typeof(IUserService)) as IUserService;
            var rolePermissionRepositiory = context.HttpContext.RequestServices.GetService(typeof(IRolePermissionService)) as IRolePermissionService;
            var permissionRepositiory = context.HttpContext.RequestServices.GetService(typeof(IPermissionService)) as IPermissionService;

            //获取账户角色
            var roleNames = userRepository.GetRoles(userName);
            var R_Permissions = new Dictionary<long, AccountPermissionsDto>();
            foreach (var roleName in roleNames)
            {
                var rolePermissions = rolePermissionRepositiory.GetRolePermissions(roleName);
                //合并角色重复的权限
                foreach (var permission in rolePermissions)
                {
                    if (!R_Permissions.ContainsKey(permission.Id))
                    {
                        R_Permissions.Add(permission.Id, permission);
                    }
                }
            }

            //判断此Api在权限列表是否有配置，如果未配置，默认都拥有权限
            var allPermission = permissionRepositiory.GetAll();
            //查找所有权限里是否存在某个权限同请求方法相等，且请求url也相等
            var existPermission = allPermission.FirstOrDefault(x => context.HttpContext.Request.Method.ToLower().Equals(x.ApiMethod.ToLower())
            && Regex.Match(context.HttpContext.Request.Path.Value.ToLower(), x.Url.ToLower()).Success);
            //不存在则返回
            if (existPermission == null)
            {
                return;
            }

            //是否有权限
            var hasPermission = R_Permissions.Values.FirstOrDefault(x => context.HttpContext.Request.Method.ToLower().Equals(x.ApiMethod.ToLower())
            && Regex.Match(context.HttpContext.Request.Path.Value.ToLower(), x.Url.ToLower()).Success);

            //此API无访问权限
            if (hasPermission == null)
            {
                var result = new ForbidResult();
                context.Result = result;
            }
        }

    }
}
