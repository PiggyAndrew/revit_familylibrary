using Autodesk.Revit.UI;
using Prism.Ioc;
using Prism.DryIoc;
using DryIoc;
using System;
using Revit.Entity;
using Revit.Shared.Interfaces;
using Revit.Mvvm.Interface;
using Revit.Mvvm;

namespace Revit.Shared.Base
{
    public abstract class ApplicationBase :PrismBootstrapperBase ,IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            Container.Resolve<IEventManager>()?.Unsubscribe();
            return Result.Succeeded;
        } 

        public Result OnStartup(UIControlledApplication application)
        {
            Container.Resolve<IEventManager>()?.Subscribe();
            var appUI = Container.Resolve<IApplication>();
            return appUI?.Initial() ?? Result.Cancelled;
        }

        protected override void RegisterTypes(IContainerRegistry container)
        {
            base.RegisterTypes(container);
            container.Register<IUIProvider, UIProvider>();
            RegisterApplicationTypes(container);
        }

        protected abstract void RegisterApplicationTypes(IContainerRegistry container);
    }
}
