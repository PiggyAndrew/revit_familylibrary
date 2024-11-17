using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Users
{
    public class UserPageResponseDto : PageResponseDto
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        public List<UserDto> Users { get; set; }
    }
}
