using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Commons
{
    public class QueryParameter
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string SearchMessage { get; set; } = "";


        public QueryParameter Next()
        {
            PageIndex++;
            return this;
        }

        public QueryParameter Previous()
        {
            PageIndex--;
            return this;
        }


        public QueryParameter SetSearchMessage()
        {
            PageIndex = 0;
            return this;
        }

    }
}
