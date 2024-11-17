using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Revit.Entity.Project
{
    public class ProjectPostPutDto
    {

        public long CreatorId { get; set; }

        public string ProjectName { get; set; } = "";

        public string ProjectAddress { get; set; } = "";

        /// <summary>
        /// 项目介绍
        /// </summary>
        public string Introduction { get; set; } = "";

        public IFormFile Icon { get; set; }
    }
}
