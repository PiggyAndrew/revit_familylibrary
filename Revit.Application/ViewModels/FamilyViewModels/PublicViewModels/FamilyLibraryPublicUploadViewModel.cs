using Abp.Extensions;
using Prism.Commands;
using Revit.Application.Converter;
using Revit.Entity;
using Revit.Families;
using Revit.Mvvm.Extensions;
using Revit.Mvvm.Interface;
using Revit.Service.IServices;
using Revit.Shared.Base;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Family;
using Revit.Shared.Extensions.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using Revit.Shared;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels
{
    //补充获取历史上传的族的方法
    public partial class FamilyLibraryPublicUploadViewModel : NavigationCurdViewModel
    {
        #region Properties
        private readonly IFamilyAppService _familyAppService;

        [ObservableProperty]
        private static FamilyPageRequestDto _queryParameter = new FamilyPageRequestDto() { Name = "", AuditStatus = FamilyAuditStatus.Auditing };
        #endregion

        #region Methods
        [RelayCommand]
        private async void UploadFamilyFiles()
        {
            var dialog = FileExtension.SelectFile(
                 (dialog) =>
                 {
                     dialog.Filter = "族文件 (*.rfa)|*.rfa";
                     dialog.Title = "选择一个文件";
                 });
            var filePath = dialog.FileName;
            var imagePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(filePath) + ".jpg");
            FamilyImageExtension.GetImage(filePath, imagePath);
            var dto = new UploadFileDtoBase() { FilesPath = new List<string>() { filePath, imagePath } };
            await _familyAppService.UploadPublicAsync(Global.User.UserId, dto).WebAsync(dataPager.SetList);
        }


        public override async Task OnNavigatedToAsync(NavigationContext navigationContext = null)
        {
            await SetBusyAsync(async () =>
            {
                await _familyAppService.GetPageListAsync(QueryParameter).WebAsync(dataPager.SetList);
            });
        }

        #endregion


        public FamilyLibraryPublicUploadViewModel(IFamilyAppService familyAppService) 
        {
            _familyAppService = familyAppService;
            dataPager.OnPageIndexChangedEventhandler += DataPager_OnPageIndexChangedEventhandler;
            OnNavigatedToAsync();
        }

        private async void DataPager_OnPageIndexChangedEventhandler(object sender, Shared.Services.Datapager.PageIndexChangedEventArgs e)
        {
            QueryParameter.SkipCount = e.SkipCount;
            QueryParameter.MaxResultCount = e.PageSize;

            await OnNavigatedToAsync();

        }
    }
}
