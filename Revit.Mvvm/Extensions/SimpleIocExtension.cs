using Prism.Ioc;
using Prism.Regions;
using Revit.Shared;
using Revit.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Revit.Mvvm.Extensions
{
    public static class IocExtension//根据传入值modeless判断是按单例注入还是瞬时注入默认瞬时注入，创建窗体实例，并给窗体的赋予DataContext，传回窗体实例
    {
        //
        public static TView Resolve<TView, TViewModel>(this IContainerProvider container) where TView : Window where TViewModel : class
        {
            var view = container.Resolve<TView>();
            view.DataContext = container.Resolve<TViewModel>();
            RegionManager.SetRegionManager(view, ContainerLocator.Container.Resolve<IRegionManager>());
            RegionManager.UpdateRegions();
            return view;
        }

    }
}
