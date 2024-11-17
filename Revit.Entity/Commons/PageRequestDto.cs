using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Commons
{
    /// <summary>
    /// 请求实体
    /// </summary>
    public class PageRequestDto
    {
        /// <summary>
        /// 每页记录数量
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }


        public string? SearchMessage { get; set; } = "";
    }
}
