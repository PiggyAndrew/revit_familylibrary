using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Family
{
    public class FamilyCategoryDto
    {

        /// <summary>
        /// 权限Id列表
        /// </summary>
        public List<long> PermissionIds { get; set; } = new List<long>();

    }
}
