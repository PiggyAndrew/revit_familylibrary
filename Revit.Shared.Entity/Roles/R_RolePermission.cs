using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Entity.Commons;

namespace Revit.Entity.Roles
{
    public class R_RolePermission : R_Entity
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public long RoleId { get; set; }

        /// <summary>
        /// 菜单Id
        /// </summary>
        public long PermissionId { get; set; }
    }
}
