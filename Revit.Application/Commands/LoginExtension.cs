using Prism.Ioc;
using Revit.Application.ViewModels.ProjectViewModels.ProjectDialogViewModels;
using Revit.Application.ViewModels.UserViewModels;
using Revit.Application.Views.ProjectViews.ProjectDialogs;
using Revit.Application.Views.UserViews;
using Revit.Entity;
using Revit.Shared;
using Revit.Shared.Base;

namespace Revit.Application.Commands
{
    public static class LoginExtension
    {
        public static bool IsUserLogin()
        {
            if (Global.User != null)
            {
                return true;
            }
            else
            {
                var loginView = ContainerLocator.Container.Resolve<LoginView>();
                if (loginView != null)
                {
                    return loginView.ShowDialog().Value;
                }
            }
            return false;
        }
    }
}
