using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Regions;
using Revit.Shared;
using Revit.ApiClient;
using CommunityToolkit.Mvvm.Input;
using Revit.Shared.Models;
using Revit.Shared.Consts;
using System.Threading.Tasks;
using HandyControl.Controls;
using Revit.Application.Services;
using Revit.Application.Services.Navigation;
using Revit.Application.Views.FamilyViews.PublicViews;
using Revit.Shared.ViewModels;

namespace Revit.Application.ViewModels
{
    public partial class MainViewModel : NavigationViewModel
    {
        private readonly IRegionManager _regionManager;

        private readonly IApplicationContext _applicationContext;

        [ObservableProperty]
        private IApplicationService _appService;

        [ObservableProperty]
        private NavigationService _navigationService;

        public MainViewModel(
            IRegionManager regionManager,
            NavigationService navigationService
            , IApplicationService appService
        //,IApplicationContext applicationContext
        )
        {
            _regionManager = regionManager;
            _navigationService = navigationService;
            _appService = appService;
            //_applicationContext = applicationContext;
        }




        [RelayCommand]
        public void Navigate(NavigationItem item)
        {
            if (item == null) return;

            NavigationService.Navigate(item.PageViewName);
        }


        public override async Task OnNavigatedToAsync(NavigationContext navigationContext=null)
        {
            MessageBox.Show("1");
            //IsShowUserPanel = false;
            await _appService.GetApplicationInfo();

            //if (_applicationContext.Configuration.Auth.GrantedPermissions.ContainsKey(AppPermissions.HostDashboard))
            NavigationService.Navigate(nameof(FamilyLibraryPublicView));
        }



    }
}
