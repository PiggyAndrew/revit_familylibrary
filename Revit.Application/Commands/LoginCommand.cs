using System;
using System.Windows;
using AppFramework.Admin;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Prism.Ioc;
using Prism.Regions;
using Revit.Application.Services;
using Revit.Application.Services.Navigation;
using Revit.Application.Validations;
using Revit.Application.ViewModels;
using Revit.Application.Views;
using Revit.Application.Views.FamilyViews.PrivateViews;
using Revit.Extension;
using Revit.Mvvm.Extensions;
using Revit.Shared;
using Revit.Shared.Base;
using Revit.Shared.Interfaces;

namespace Revit.Application.Commands
{
    [Transaction(TransactionMode.Manual)]
    [Journaling(JournalingMode.NoCommandData)]
    [Regeneration(RegenerationOption.Manual)]
    public class Login : CommandBase
    {
        protected override DependencyObject CreateShell()
        {
            if (!LoginExtension.IsUserLogin())
            {
                return null;
            }
            return Container.Resolve<MainView, MainViewModel>();
        }

        protected override void RegisterCommandTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.AddViews();
            containerRegistry.AddServices();
            containerRegistry.AddValidators();
        }

        protected override void OnInitialized()
        {
            if (this.Shell  is Window window)
            {
                window.ShowDialog();
            }
        }
    }
}
