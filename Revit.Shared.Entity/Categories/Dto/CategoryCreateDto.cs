using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Shared.Entity.Commons;

namespace Revit.Shared.Entity.Family
{
    public class CategoryCreateDto : DtoBase
    {
        public long ParentId { get; set; }

        public string Name { get; set; } = "";

        public CategoryType CategoryType { get; set; }
    }
}
