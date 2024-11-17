using Prism.Services.Dialogs;
using Revit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using Revit.Authorization.Users;
using Revit.Shared.Entity.Users;
using Revit.Shared.Extensions.Threading;
using Revit.Application.Views.UserViews.DialogViews;
using Revit.Shared.Entity.Authorization.Users;

namespace Revit.Application.ViewModels.UserViewModels
{
    public partial class UserViewModel : NavigationCurdViewModel
    {
        private readonly IUserAppService userAppService;
        private readonly IDialogService dialogService;

        [ObservableProperty]
        private static UserPageRequestDto _userQueryParameter = new UserPageRequestDto() { UserName = "" };

        [RelayCommand]
        private async Task Delete(UserDto user)
        {
            if (MessageBox.Show("删除用户后不可恢复，请是否确认删除！", "提示", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                await userAppService.DeleteUser(new Abp.Application.Services.Dto.EntityDto<long>(user.Id)).WebAsync(async () => { await GetUsers(); });
            }
        }

        private async Task GetUsers()
        {
            await userAppService.GetPageListAsync(UserQueryParameter).WebAsync(dataPager.SetList);
        }

        [RelayCommand]
        private async Task GetPermissions()
        {
            //await permissionService.GetAllPermissions().WebAsync((permissions) =>
            // {
            //     if (permissions != null && permissions.Any())
            //     {
            //         Permissions = new ObservableCollection<PermissionDto>(permissions);
            //     }
            //     return Task.CompletedTask;
            // });


        }


        public override async Task OnNavigatedToAsync(NavigationContext navigationContext = null)
        {
            await SetBusyAsync(async () =>
            {
                await GetUsers();
            });
        }

        public UserViewModel(IUserAppService userAppService, IDialogService dialogService)
        {
            this.userAppService = userAppService;
            this.dialogService = dialogService;
            dataPager.OnPageIndexChangedEventhandler += DataPager_OnPageIndexChangedEventhandler;

            OnNavigatedToAsync();
        }

        private void DataPager_OnPageIndexChangedEventhandler(object sender, Shared.Services.Datapager.PageIndexChangedEventArgs e)
        {
            _userQueryParameter.SkipCount = e.SkipCount;
            _userQueryParameter.MaxResultCount = e.PageSize;

            OnNavigatedToAsync();
        }
    }
}
