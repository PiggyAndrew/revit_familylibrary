using Revit.Shared.Entity.Commons;
using System.Collections.Generic;

namespace Revit.Shared.Entity.Family
{
    public class CategoryDto : DtoBase
    {
        public long ParentId { get; set; }

        public string Name { get; set; } = "";


        public CategoryType CategoryType { get; set; }
    }
}
