using Prism.Ioc;
using Revit.Entity;
using Revit.Mvvm.Interface;
using Revit.Shared.Base;
using Revit.Shared.Interfaces;
using Revit.Application.Services;
using Revit.Application.Validations;
using Revit.Application.Views;

namespace Revit.Application.UI
{
    public class Application : ApplicationBase
    {
        protected override void RegisterApplicationTypes(IContainerRegistry container)
        {
            container.RegisterSingleton<IDataContext, DataContext>();
            container.Register<IEventManager, ApplicationEvent>();
            container.Register<IApplication, ApplicationUI>();

            container.AddViews();
            container.AddServices();
            container.AddValidators();
        }
    }
}
