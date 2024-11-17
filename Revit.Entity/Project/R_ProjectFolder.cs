using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class R_ProjectFolder:R_File
    {

        [Comment("项目Id")]
        public long ProjectId { get; set; }


        [Comment("是否为根路径")]
        public bool IsRoot { get; set; }

    }
}
