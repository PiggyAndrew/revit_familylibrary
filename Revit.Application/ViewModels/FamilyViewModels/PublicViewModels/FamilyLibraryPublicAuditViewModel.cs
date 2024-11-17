using Prism.Commands;
using Prism.Services.Dialogs;
using Revit.Application.Views.FamilyViews.Public.DialogViews;
using Revit.Families;
using Revit.Mvvm.Services;
using Revit.Service.IServices;
using Revit.Shared;
using Revit.Shared.Entity.Family;
using Revit.Shared.Extensions.Threading;
using Revit.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels
{
    public partial class FamilyLibraryPublicAuditViewModel : NavigationCurdViewModel
    {

        #region Properties
        private readonly IFamilyAppService _familyAppService;
        private readonly IDialogService _dialogService;

        [ObservableProperty]
        private ObservableCollection<FamilyDto> _auditingFamilies = new ObservableCollection<FamilyDto>();

        [ObservableProperty]
        private static FamilyPageRequestDto _queryParameter = new FamilyPageRequestDto() { Name = "", AuditStatus = FamilyAuditStatus.Auditing };


        [ObservableProperty]
        private ComboboxItems<FamilyAuditStatus> _auditStatusOptions = new ComboboxItems<FamilyAuditStatus>() { Items = new ObservableCollection<FamilyAuditStatus>(new List<FamilyAuditStatus>() { FamilyAuditStatus.Auditing, FamilyAuditStatus.Retry, FamilyAuditStatus.Pass, FamilyAuditStatus.NotPass }) };
        #endregion



        #region Methods

        [RelayCommand]
        private async void AuditFamily(FamilyDto selectedFamily)
        {
            var parameters = new DialogParameters { { "Value", selectedFamily } };

            IDialogResult dialogResult = new DialogResult(ButtonResult.Cancel);
            dialogService.ShowDialog(nameof(AuditingFamilyDialogView), parameters, (result =>
            {
                dialogResult = result;
            }));
            if (dialogResult.Result == ButtonResult.OK)
                await OnNavigatedToAsync();
        }

        [RelayCommand]
        private async void FilterAuditingFamilies()
        {
            await OnNavigatedToAsync();
        }
        #endregion






        public FamilyLibraryPublicAuditViewModel(IFamilyAppService familyAppService, IDialogService dialogService)
        {
            _familyAppService = familyAppService;
            _dialogService = dialogService;

            OnNavigatedToAsync();
        }


        public override async Task OnNavigatedToAsync(NavigationContext navigationContext = null)
        {
            await SetBusyAsync(async () =>
            {
                await _familyAppService.GetPageListAsync(QueryParameter).WebAsync(dataPager.SetList);
            });
        }
    }
}
