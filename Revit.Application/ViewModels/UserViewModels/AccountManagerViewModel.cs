using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using Prism.Services.Dialogs;
using Revit.Application.Views.UserViews.DialogViews;
using Revit.Shared;
using Revit.Shared.Entity.Authorization.Users;
using Revit.Shared.Entity.Users;
using Revit.Shared.Extensions.Threading;

namespace Revit.Application.ViewModels.UserViewModels
{
    public partial class AccountManagerViewViewModel : NavigationCurdViewModel
    {
        private readonly IUserAppService userAppService;
        private readonly IDialogService dialogService;

        [ObservableProperty]
        private static UserPageRequestDto _userQueryParameter = new UserPageRequestDto()
        {
            UserName = "",
        };

        [RelayCommand]
        private async Task AddUsers()
        {
            dialogService.ShowDialog(
                nameof(AddUserDialogView),
                null,
                async (IDialogResult result) => { }
            );
        }

        [RelayCommand]
        private async Task DeleteUser(UserDto user)
        {
            if (
                MessageBox.Show(
                    "删除用户后不可恢复，请是否确认删除！",
                    "提示",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning
                ) == MessageBoxResult.Yes
            )
            {
                await userAppService
                    .DeleteUser(new Abp.Application.Services.Dto.EntityDto<long>(user.Id))
                    .WebAsync(async () =>
                    {
                        await GetUsers();
                    });
            }
        }

        public async void Init()
        {
            await GetUsers();
        }

        [RelayCommand]
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
                await userAppService
                    .GetPageListAsync(UserQueryParameter)
                    .WebAsync(dataPager.SetList);
            });
        }

        public AccountManagerViewViewModel(
            IUserAppService userAppService,
            IDialogService dialogService
        )
        {
            this.userAppService = userAppService;
            this.dialogService = dialogService;
        }
    }
}
