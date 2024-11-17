using CommunityToolkit.Mvvm.Input;
using Revit.Entity;
using Revit.Service.IServices;
using Revit.Shared;
using Revit.Shared.Entity.Commons;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Application.Services;
using Revit.Application.Services.Navigation;
using Revit.Application.Views.FamilyViews.PublicViews;
using Revit.IServices;
using Revit.Shared.Entity.Auths;
using Revit.Shared.Entity.Auths.Dto;

namespace Revit.Application.ViewModels.UserViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {

        private Visibility _progressBarVisibility = Visibility.Hidden;

        public Visibility ProgressBarVisibility
        {
            get { return _progressBarVisibility; }
            set { SetProperty(ref _progressBarVisibility, value); }
        }

        private readonly IAuthsAppService _authsService;
        private readonly IApplicationService _appService;

        [ObservableProperty]
        private AbpAuthenticateModel _abpAuthenticateModel;

        private readonly NavigationService _navigationService;


        public LoginViewModel( IAuthsAppService authsService, AbpAuthenticateModel abpAuthenticateModel, IApplicationService appService, NavigationService navigationService)
        {
            this._authsService = authsService;
            _abpAuthenticateModel = abpAuthenticateModel;
            _appService = appService;
            _navigationService = navigationService;

              _appService.GetApplicationInfo();
        }

        [RelayCommand]
        private async Task Login(Window window)
        {
            AbpAuthenticateModel.UserNameOrEmailAddress = "admin";
            AbpAuthenticateModel.Password = "Abc123@";
            await _authsService.LoginAsync();
            ProgressBarVisibility = Visibility.Visible;
            if (true)
            {
                    window.DialogResult = true;
            }
            ProgressBarVisibility = Visibility.Hidden;

        }

        public static void LoginOut()
        {

        }
    }
}
