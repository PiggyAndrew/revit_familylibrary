using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Shared.Entity.Commons.Dto;

namespace Revit.Shared.Entity.Roles
{
    /// <summary>
    /// 角色翻页查询
    /// </summary>
    public class RolePageRequestDto 
    {
        /// <summary>
        /// 用户昵称
        /// </summary>
        public string Name { get; set; }
    }
}
