using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Roles
{
    /// <summary>
    /// 角色翻页响应对象
    /// </summary>
    public class RolePageResponseDto : PageResponseDto
    {
        /// <summary>
        /// 角色列表
        /// </summary>
        public List<RoleDto> Roles { get; set; }
    }
}
