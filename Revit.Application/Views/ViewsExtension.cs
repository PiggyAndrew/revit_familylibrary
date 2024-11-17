using Prism.Ioc;
using Revit.Application.ViewModels.FamilyViewModels.PublicViewModels.DialogViewModels;
using Revit.Application.ViewModels.FamilyViewModels.PublicViewModels;
using Revit.Application.ViewModels.FamilyViewModels;
using Revit.Application.ViewModels.ProjectViewModels;
using Revit.Application.ViewModels.UserViewModels;
using Revit.Application.ViewModels;
using Revit.Application.Views.FamilyViews.Public.DialogViews;
using Revit.Application.Views.FamilyViews.PublicViews;
using Revit.Application.Views.FamilyViews;
using Revit.Application.Views.ProjectViews;
using Revit.Application.Views.UserViews.DialogViews;
using Revit.Application.Views.UserViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Application.ViewModels.ProjectViewModels.ProjectDialogViewModels;
using Revit.Application.Views.ProjectViews.ProjectDialogs;
using Revit.Application.Views.FamilyViews.PublicViews.DialogViews;

namespace Revit.Application.Views
{
    public static class ViewsExtension
    {
        public static void AddViews(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainProjectView, MainProjectViewModel>();
            containerRegistry.RegisterForNavigation<TotalProjectView, DisPlayProjectViewModel>();
            containerRegistry.RegisterForNavigation<RecentlyProjectView, DisPlayProjectViewModel>();
            containerRegistry.RegisterForNavigation<ProjectFileManageView, ProjectFileManageViewModel>();
            containerRegistry.RegisterForNavigation<ProjectMemberView, ProjectMemberViewModel>();
            containerRegistry.RegisterForNavigation<ProjectView, ProjectViewModel>();
            containerRegistry.RegisterForNavigation<FamilyLibraryPublicView, FamilyLibraryPublicViewModel>();
            containerRegistry.RegisterForNavigation<FamilyLibaryPublicUploadView, FamilyLibraryPublicUploadViewModel>();
            containerRegistry.RegisterForNavigation<FamilyLibraryPublicAuditView, FamilyLibraryPublicAuditViewModel>();
            containerRegistry.RegisterForNavigation<FamilyLibraryTagsView, FamilyLibraryTagsViewModel>();
            containerRegistry.RegisterForNavigation<WorkSpaceView, WorkSpaceViewModel>();
            containerRegistry.RegisterForNavigation<AccountManagerView, AccountManagerViewViewModel>();
            containerRegistry.RegisterForNavigation<RoleView, RoleViewModel>();
            containerRegistry.RegisterForNavigation<UserView, UserViewModel>();
            containerRegistry.RegisterForNavigation<LoginView, LoginViewModel>(); 
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>(); 

            containerRegistry.RegisterDialog<ProjectCreateDialog, ProjectCreateDialogViewModel>();
            containerRegistry.RegisterDialog<AddUserDialogView, AddUserDialogViewModel>();
            containerRegistry.RegisterDialog<AddRoleDialogView, AddRoleDialogViewModel>();
            containerRegistry.RegisterDialog<AuditingFamilyDialogView, AuditingFamilyDialogViewModel>();
            containerRegistry.RegisterDialog<AddFamilyLibraryTagsDialogView, AddFamilyLibraryTagsDialogViewModel>();

            containerRegistry.RegisterDialogWindow<DefaultDialog>();
        }
    }
}
