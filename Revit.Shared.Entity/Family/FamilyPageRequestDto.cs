using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Shared.Entity.Commons.Dto;

namespace Revit.Shared.Entity.Family
{
    public class FamilyPageRequestDto : PagedInputDto
    {
        public string Name { get; set; } = "";

        public List<long> CategoriesIds { get; set; } = new List<long>();

        public FamilyAuditStatus AuditStatus { get; set; } = FamilyAuditStatus.Pass;
    }
}
