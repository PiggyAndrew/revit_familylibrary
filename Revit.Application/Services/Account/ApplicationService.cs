using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AppFramework.Admin.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Regions;
using Prism.Services.Dialogs;
using Revit.ApiClient;
using Revit.Application.Services.Navigation;
using Revit.Service.IServices;
using Revit.Shared;
using Revit.Shared.Consts;
using Revit.Shared.Interfaces;
using Revit.Shared.Models;
using Revit.Shared.Services.Permission;

namespace Revit.Application.Services
{
    public partial class ApplicationService : ViewModelBase, IApplicationService
    {
        public ApplicationService(
            //IHostDialogService dialog,
            IDialogService dialogService,
            IRegionManager regionManager,
           // IAccountService accountService,
            INavigationMenuService navigationItemService,
            //IProfileAppService profileAppService,
            //IApplicationContext applicationContext,
            NavigationService navigationService
            //,NotificationService notificationService
            )
        {
            //this.dialog = dialog;
            //this.accountService = accountService;
            //this.applicationContext = applicationContext;
            this._navigationService = navigationService;
            //this.notificationService = notificationService;
            this._dialogService = dialogService;
            this._navigationItemService = navigationItemService;
            this._regionManager = regionManager;
            //this.profileAppService = profileAppService;

            navigationItems = new ObservableCollection<NavigationItem>();
        }

        #region 字段/属性

        private readonly IApplicationContext _applicationContext;
        private readonly NavigationService _navigationService;
        //private readonly NotificationService notificationService;
        private readonly IDialogService _dialogService;
        private readonly IHostDialogService _dialog;
        private readonly INavigationMenuService _navigationItemService;
        private readonly IRegionManager _regionManager;
        private readonly IAccountService _accountService;
        //private readonly IProfileAppService profileAppService;

        [ObservableProperty] private byte[] _photo;
        [ObservableProperty] private byte[] _profilePictureBytes;
        [ObservableProperty] private string _userNameAndSurname;
        [ObservableProperty] private string _emailAddress;
        [ObservableProperty] private string _applicationInfo;
        [ObservableProperty] private string _applicationName;
        [ObservableProperty] private ObservableCollection<NavigationItem> navigationItems;
        [ObservableProperty] private ObservableCollection<PermissionItem> userMenuItems;

        

        #endregion

        #region 用户方法

        public async Task ShowMyProfile()
        {
            _dialogService.Show(AppViews.MyProfile);
            await Task.CompletedTask;
        }

        //protected async Task GetUserPhoto()
        //{
        //    await WebRequest.Execute(() => profileAppService.GetProfilePictureByUser(applicationContext.LoginInfo.User.Id),
        //         GetProfilePictureByUserSuccessed);
        //}

        //private async Task GetProfilePictureByUserSuccessed(GetProfilePictureOutput output)
        //{
        //    if (output != null)
        //        Photo = Convert.FromBase64String(output.ProfilePicture);
        //    await Task.CompletedTask;
        //}

        public async Task ShowProfilePhoto()
        {
            if (_profilePictureBytes == null) return;

            NavigationParameters param = new NavigationParameters();
            param.Add("Value", _profilePictureBytes);
            _regionManager.Regions[AppRegions.Main].RequestNavigate(AppViews.ProfilePicture, param);

            await Task.CompletedTask;
        }

        #endregion

        #region 用户菜单方法

        private int selectedIndex = -1;

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; OnPropertyChanged(); }
        }

        public async Task GetApplicationInfo()
        {
            //await GetUserPhoto();

            //ApplicationName = Local.Localize("EmailActivation_Title");

            //UserNameAndSurname = applicationContext.LoginInfo.User.Name;
           // EmailAddress = applicationContext.LoginInfo.User.EmailAddress;

            RefreshAuthMenus();

           // ApplicationInfo = $"{ApplicationName}\n" +
                            //$"v{applicationContext.LoginInfo.Application.Version} " +
                           // $"[{applicationContext.LoginInfo.Application.ReleaseDate:yyyyMMdd}]";
        }

        public void RefreshAuthMenus()
        {
                //  var permissions = _applicationContext.Configuration.Auth.GrantedPermissions;
            NavigationItems = _navigationItemService.GetAuthMenus(null);
            //UserMenuItems = new ObservableCollection<PermissionItem>()
            //{
            //   new PermissionItem("accounts",Local.Localize("ManageLinkedAccounts"), "",ManageLinkedAccounts),
            //   new PermissionItem("manageuser",Local.Localize("ManageUserDelegations"),"",ManageUserDelegations),
            //   new PermissionItem("password",Local.Localize("ChangePassword"),"",ChangePassword),
            //   new PermissionItem("loginattempts",Local.Localize("LoginAttempts"),"",LoginAttempts),
            //   new PermissionItem("picture",Local.Localize("ChangeProfilePicture"),"",ChangeProfilePicture),
            //   new PermissionItem("mysettings",Local.Localize("MySettings"),"",MySettings),
            //   new PermissionItem("download",Local.Localize("Download"),"",Download),
            //   new PermissionItem("logout",Local.Localize("Logout"),"",LogOut),
            //};
        }

        public void ExecuteUserAction(string key)
        {
            var item = UserMenuItems.FirstOrDefault(t => t.Key.Equals(key));
            if (item != null) item.Action?.Invoke();
        }

        private async void LogOut()
        {
            //if (await dialog.Question(Local.Localize("AreYouSure")))
            //{
            //    regionManager.Regions[AppRegions.Main].RemoveAll();
            //    await accountService.LogoutAsync();
            //}

            await ResetClickIndex();
        }

        private void ManageLinkedAccounts()
        {
            ShowPage(AppViews.ManageLinkedAccounts);
        }

        private void ManageUserDelegations()
        {
            ShowPage(AppViews.ManageUserDelegations);
        }

        private void ChangePassword()
        {
            ShowPage(AppViews.ChangePassword);
        }

        private void LoginAttempts()
        {
            _navigationService.Navigate(AppViews.LoginAttempts);
        }

        private void MySettings()
        {
            ShowPage(AppViews.MyProfile);
        }

        private async void ShowPage(string pageName)
        {
            await _dialog.ShowDialogAsync(pageName);
            await ResetClickIndex();
        }

        private async void Download()
        {
            //await profileAppService.PrepareCollectedData().WebAsync(async () =>
            //{
            //    await notificationService.GetNotifications();
            //    await ResetClickIndex();
            //    DialogHelper.Info(Local.Localize("Notifications"),
            //       Local.Localize("GdprDataPreparedNotificationMessage"));
            //});
        }

        private async void ChangeProfilePicture()
        {
            var dialogResult = await _dialog.ShowDialogAsync(AppViews.ChangeAvatar);

            if (dialogResult.Result == ButtonResult.OK)
            {
                Photo = dialogResult.Parameters.GetValue<byte[]>("Value");

                await ResetClickIndex();
            }
        }

        private async Task ResetClickIndex()
        {
            SelectedIndex = -1;

            await Task.Delay(200);
        }

        #endregion
    }
}
