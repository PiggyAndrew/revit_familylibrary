using Revit.Shared.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Project
{
    public class ProjectFolderDto : DtoBase
    {

        public string Name { get; set; } = "";

        public string CreatorName { get; set; } = "";

        public string FileSize { get; set; } = "";

        public string FileExtension { get; set; } = "";
        public string RelativePath { get; set; } = "";

        public bool IsRoot { get; set; }

    }
}
