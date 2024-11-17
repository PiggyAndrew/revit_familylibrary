using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Family
{
    public class FamilyUploadDto
    {

        public IFormFileCollection Files { get; set; }

    }
}
