using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Roles
{
    /// <summary>
    /// 角色翻页查询
    /// </summary>
    public class RolePageRequestDto : PageRequestDto
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string? Name { get; set; }
    }
}
