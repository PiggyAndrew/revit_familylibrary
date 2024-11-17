using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Family
{
    public class FamilyPutDto : R_DtoBase
    {
        public FamilyAuditStatus FamilyAuditStatus { get; set; }

        public List<long> CategoriesIds { get; set; }=new List<long>();
    }
}
