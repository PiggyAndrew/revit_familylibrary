using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.IServices
{
    public interface IExcelTransfer<TElement>//Excel联动接口
    {
        IEnumerable<TElement> Import();//获取数据

        void Expor(IEnumerable<TElement> elements);//输出数据

    }
}
