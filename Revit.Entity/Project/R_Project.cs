using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class R_Project : R_Entity
    {
        [Comment("项目名称")]
        public string ProjectName { get; set; } = "";

        [Comment("项目地址")]
        public string ProjectAddress { get; set; } = "";


        [Comment("项目介绍")]
        public string Introduction { get; set; } = "";

        [Comment("图标路径")]
        public string IconPath { get; set; } = "";



    }
}
