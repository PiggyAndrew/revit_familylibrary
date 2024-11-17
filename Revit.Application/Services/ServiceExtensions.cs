using Prism.Ioc;
using Revit.Application.Services.Navigation;
using Revit.Shared.Services.App;
using Revit.Mvvm.Services;

namespace Revit.Application.Services
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IContainerRegistry services)
        {
            services.RegisterSingleton<NavigationService>();

            services.RegisterSingleton<IAppMapper, AppMapper>();
            services.RegisterSingleton<IFamilyService, FamilyService>();

           services.RegisterSingleton<IApplicationService, ApplicationService>();
            services.RegisterSingleton<INavigationMenuService, NavigationMenuService>();

        }
    }
}
