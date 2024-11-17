using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using Revit.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class ProjectRequestDto : PageRequestDto
    {
        //删除
        public long UserId { get; set; }

    }
}
