using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using Prism.Services.Dialogs;
using Revit.Shared;
using Revit.Shared.Extensions.Threading;
using Revit.Shared.Services.Datapager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revit.Shared.Entity.Authorization.Roles;
using Revit.Shared.Entity.Permissions;
using Revit.Shared.Entity.Roles;
using Revit.Commons;

namespace Revit.Application.ViewModels.UserViewModels
{
    public partial class RoleViewModel : NavigationCurdViewModel
    {
        private readonly IRoleAppService _roleAppService;

        [ObservableProperty]
        private static RolePageRequestDto _userQueryParameter = new RolePageRequestDto() { Name = "" };

        [ObservableProperty]
        private ObservableCollection<PermissionDto> _permissionList;

        public RoleViewModel(IRoleAppService roleAppService)
        {
            this._roleAppService = roleAppService;
            dataPager.OnPageIndexChangedEventhandler += RoleOnPageIndexChangedEventhandler;
            OnNavigatedToAsync();
        }

        [RelayCommand]
        public async void RoleSelectionChanged()
        {
            if (dataPager.SelectedItem is RoleCreateDto role)
            {
                await SetBusyAsync(async () =>
                {
                    await _roleAppService.GetRolePermissions(role.Id).WebAsync(successCallback: (permissions) =>
                    {
                        PermissionList = new ObservableCollection<PermissionDto>(permissions);
                        return Task.CompletedTask;
                    });
                });
            }
        }

        private async void RoleOnPageIndexChangedEventhandler(object sender, PageIndexChangedEventArgs e)
        {
            OnNavigatedToAsync();
        }

        public override async Task OnNavigatedToAsync(NavigationContext navigationContext = null)
        {
            await SetBusyAsync(async () =>
            {
                await _roleAppService.GetListAsync(_userQueryParameter).WebAsync(dataPager.SetList);
            });
        }
    }
}
