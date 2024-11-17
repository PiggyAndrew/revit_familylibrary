using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Roles
{
    /// <summary>
    /// 角色分配权限
    /// </summary>
    public class RolePermissionDto
    {
        /// <summary>
        /// 权限Id列表
        /// </summary>
        public List<long> PermissionIds { get; set; }
    }
}
