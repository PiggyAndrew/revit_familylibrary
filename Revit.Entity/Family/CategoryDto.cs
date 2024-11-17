using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Entity.Commons;
using Revit.Entity.Family;
using Microsoft.EntityFrameworkCore;

namespace Revit.Entity.Entity.Dtos.Family
{
    public class CategoryDto : R_DtoBase
    {
        public long ParentId { get; set; }

        public string Name { get; set; } = "";

        public CategoryType CategoryType { get; set; }
    }
}
