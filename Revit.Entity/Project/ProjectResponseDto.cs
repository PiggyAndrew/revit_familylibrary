using Revit.Entity.Accounts;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Project
{
    public class ProjectResponseDto : R_Entity
    {

        public string? ProjectName { get; set; }

        public AccountDto UserDto { get; set; }

        public int ProjectUserCount { get; set; }

        public double DocumentsSize { get; set; }

        public string BasePath { get; set; }


    }
}
