using CommonServiceLocator;
using DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions.Behaviors;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using Prism.DryIoc.Ioc;
using Prism.DryIoc;
using Prism.Events;
using Prism.Logging;
using Prism.Services.Dialogs;
using Revit.Application.ViewModels.FamilyViewModels;
using Revit.Entity.Interfaces;
using Revit.Entity;
using Revit.Service.ApiServices;
using Revit.Service.IServices;
using Revit.Service.Services;
using System.Xml.Serialization;

namespace Revit.Mvvm
{
    public abstract  class Host
    {
        private static readonly IContainerExtension _containerExtension = CreateContainerExtension();

        private static readonly IModuleCatalog _moduleCatalog = new ModuleCatalog();

        public static IContainerProvider Container => _containerExtension;

        public  void Start(Action<IContainerExtension> action = null)
        {
            ViewModelLocationProvider.SetDefaultViewModelFactory((view, type) => Container.Resolve(type));

            _containerExtension.RegisterInstance(_containerExtension);
            _containerExtension.RegisterInstance(_moduleCatalog);
            if (action != null)
            {
                action.Invoke(_containerExtension);
            }

            RegisterRequiredTypes(_containerExtension);
            _containerExtension.FinalizeExtension();

            ServiceLocator.SetLocatorProvider(() => Container.Resolve<IServiceLocator>());

            ConfigureModuleCatalog(_moduleCatalog);

            RegionAdapterMappings regionAdapterMappings = Container.Resolve<RegionAdapterMappings>();
            if (regionAdapterMappings != null)
            {
                regionAdapterMappings.RegisterMapping(typeof(Selector), Container.Resolve<SelectorRegionAdapter>());
                regionAdapterMappings.RegisterMapping(typeof(ItemsControl), Container.Resolve<ItemsControlRegionAdapter>());
                regionAdapterMappings.RegisterMapping(typeof(ContentControl), Container.Resolve<ContentControlRegionAdapter>());
            }

            IRegionBehaviorFactory regionBehaviorFactory = Container.Resolve<IRegionBehaviorFactory>();
            if (regionBehaviorFactory != null)
            {
                regionBehaviorFactory.AddIfMissing(BindRegionContextToDependencyObjectBehavior.BehaviorKey, typeof(BindRegionContextToDependencyObjectBehavior));
                regionBehaviorFactory.AddIfMissing(RegionActiveAwareBehavior.BehaviorKey, typeof(RegionActiveAwareBehavior));
                regionBehaviorFactory.AddIfMissing(SyncRegionContextWithHostBehavior.BehaviorKey, typeof(SyncRegionContextWithHostBehavior));
                regionBehaviorFactory.AddIfMissing(RegionManagerRegistrationBehavior.BehaviorKey, typeof(RegionManagerRegistrationBehavior));
                regionBehaviorFactory.AddIfMissing(RegionMemberLifetimeBehavior.BehaviorKey, typeof(RegionMemberLifetimeBehavior));
                regionBehaviorFactory.AddIfMissing(ClearChildViewsRegionBehavior.BehaviorKey, typeof(ClearChildViewsRegionBehavior));
                regionBehaviorFactory.AddIfMissing(AutoPopulateRegionBehavior.BehaviorKey, typeof(AutoPopulateRegionBehavior));
                regionBehaviorFactory.AddIfMissing(IDestructibleRegionBehavior.BehaviorKey, typeof(IDestructibleRegionBehavior));
            }

            ExceptionExtensions.RegisterFrameworkExceptionType(typeof(ActivationException));
            ExceptionExtensions.RegisterFrameworkExceptionType(typeof(ContainerException));

            Container.Resolve<IModuleManager>()?.Run();

        }




        /// <summary>
        /// Configures the <see cref="IModuleCatalog"/> used by Prism.
        /// </summary>
        protected  virtual void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) { }

        private static IContainerExtension CreateContainerExtension()
        {
            Rules rules = Rules.Default.WithAutoConcreteTypeResolution()
                .WithDefaultIfAlreadyRegistered(IfAlreadyRegistered.Replace)
                .With(Made.Of(FactoryMethod.ConstructorWithResolvableArguments));
            //Rules rules = Rules.Default;
            return new DryIocContainerExtension(new Container(rules));
        }

        private static void RegisterRequiredTypes(IContainerRegistry registry)
        {
            // Base WPF Application types
            registry.RegisterSingleton<ILoggerFacade, TextLogger>();
            registry.RegisterSingleton<IDialogService, Revit.Mvvm.Prism.DialogService>();
            registry.RegisterSingleton<IModuleInitializer, ModuleInitializer>();
            registry.RegisterSingleton<IModuleManager, ModuleManager>();
            registry.RegisterSingleton<RegionAdapterMappings>();
            registry.RegisterSingleton<IRegionManager, RegionManager>();
            registry.RegisterSingleton<IEventAggregator, EventAggregator>();
            registry.RegisterSingleton<IRegionViewRegistry, RegionViewRegistry>();
            registry.RegisterSingleton<IRegionBehaviorFactory, RegionBehaviorFactory>();
            registry.Register<IRegionNavigationJournalEntry, RegionNavigationJournalEntry>();
            registry.Register<IRegionNavigationJournal, RegionNavigationJournal>();
            registry.Register<IRegionNavigationService, RegionNavigationService>();
            registry.Register<IDialogWindow, DialogWindow>(); //default dialog host

            // Special WPF Application types
            registry.RegisterSingleton<IRegionNavigationContentLoader, RegionNavigationContentLoader>();
            registry.RegisterSingleton<IServiceLocator, DryIocServiceLocatorAdapter>();

            //注册Doucment

            registry.RegisterSingleton<IDataContext, DataContext>();
            registry.RegisterInstance(new MyHttpClient(Global.HOST));


            registry.Register<ILoginService, LoginService>();
            registry.Register<IProjectService, ProjectService>();
            registry.Register<IProjectFolderService, ProjectFolderService>();
            registry.Register<IProjectFileService, ProjectFileService>();
        }
    }
}
