using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper.Configuration;
using Prism.DryIoc;
using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace Revit.Shared
{
    public class PrismBootstrapperBase : PrismBootstrapper
    {
        public PrismBootstrapperBase():base()
        {
            
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.AddSharedServices();
        }

        protected override DependencyObject CreateShell()
        {
            return null;
        }
    }
}
