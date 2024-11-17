using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class R_ProjectUser : R_Entity
    {
        [Comment("项目Id")]
        public long ProjectId { get; set; }

        [Comment("用户Id")]
        public long UserId { get; set; }
    }
}
