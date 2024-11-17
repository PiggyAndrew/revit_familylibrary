using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Family
{
    public class R_Category : R_Entity
    {
        [Comment("类别名称")]
        public string Name { get; set; }="";

        [Comment("递归表存储树形关系")]
        public long ParentId { get; set; }

        [Comment("分类类型")]
        public CategoryType CategoryType { get; set; }
    }

    public enum CategoryType
    {
        Major,
        ElementType,
        Software,
        Producer,
        Property,
        Keyword
    }

}
