using AutoMapper;
using Prism.Services.Dialogs;
using Revit.Shared;
using Revit.Shared.Entity.Roles;
using Revit.Shared.Extensions.Threading;
using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Shared.Entity.Authorization.Roles;

namespace Revit.Application.ViewModels.UserViewModels
{
    public partial class AddRoleDialogViewModel : DialogViewModel
    {
        public AddRoleDialogViewModel()
        {

        }

        private IRoleAppService _roleAppService;

        [ObservableProperty]
        private RoleCreateDto _role;
        private readonly IMapper mapper;

       


        public AddRoleDialogViewModel(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService ?? throw new ArgumentNullException(nameof(roleAppService));
        }

        public override async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await _roleAppService.PostRole(Role).WebAsync(successCallback: base.Save);
            });
        }


        public override async void OnDialogOpened(IDialogParameters parameters)
        {
            await SetBusyAsync(async () =>
            {
                long? id = parameters?.GetValue<RoleCreateDto>("Value")?.Id;

                var output = await _roleAppService.GetRole(id);
                Role = Map<RoleCreateDto>(output.Role);
            });
        }


    }
}
