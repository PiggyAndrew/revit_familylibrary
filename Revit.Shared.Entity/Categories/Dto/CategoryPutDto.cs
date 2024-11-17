using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Family;
using System;
using System.Collections.Generic;
using System.Text;

namespace Revit.Shared.Entity.Categories
{
    public class CategoryPutDto: DtoBase
    {
        public long ParentId { get; set; }

        public string Name { get; set; } = "";

        public CategoryType CategoryType { get; set; }
    }
}
