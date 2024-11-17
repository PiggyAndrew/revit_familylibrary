using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.IServices
{
    public interface IDataService<TElement>//revit元素处理用的接口
    {
        IEnumerable<TElement> GetDataServices(Func<TElement, bool> predicate = null);//获取构件

        void DeleteElement(TElement element);//删除单个构件

        void DeleteElements(IEnumerable<TElement> elements);//删除多个构件

        TElement CreateElement(string name);//创建构件




    }
}
