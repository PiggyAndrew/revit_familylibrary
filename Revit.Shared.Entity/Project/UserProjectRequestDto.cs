using Revit.Shared.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Project
{
    public class UserProjectRequestDto : DtoBase
    {
        public long UserId { get; set; }
    }
}
