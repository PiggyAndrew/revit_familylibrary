using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using Revit.Categories;
using Revit.Families;
using Revit.Shared;
using Revit.Shared.Entity.Family;
using Revit.Shared.Extensions.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Abp.Application.Services.Dto;
using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Mvvm.Services;
using Revit.Service.Services;
using Revit.Shared.Services.Datapager;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels
{
    public partial class FamilyLibraryPublicViewModel : NavigationCurdViewModel
    {
        #region Properties
        private readonly IFamilyAppService _familyAppService;
        private readonly IFamilyService _familyService;
        private readonly ICategoryAppService _categoryAppService;




        [ObservableProperty]
        private ObservableCollection<object> _categories = new ObservableCollection<object>();

        [ObservableProperty]
        private ObservableCollection<object> _tags;

        [ObservableProperty]
        private FamilyPageRequestDto _queryParameter = new FamilyPageRequestDto() { Name = "", AuditStatus = FamilyAuditStatus.Pass };
        #endregion

        public FamilyLibraryPublicViewModel(IFamilyAppService familyAppService, IFamilyService familyService, ICategoryAppService categoryAppService)
        {
            _familyAppService = familyAppService;
            _familyService = familyService;
            _categoryAppService = categoryAppService;
            dataPager.OnPageIndexChangedEventhandler += DataPager_OnPageIndexChangedEventhandler;
            InitCategories();
        }

        private void DataPager_OnPageIndexChangedEventhandler(object sender, PageIndexChangedEventArgs e)
        {
            QueryParameter.SkipCount = e.SkipCount;
            QueryParameter.MaxResultCount = e.PageSize;
            OnNavigatedToAsync();
        }

        #region CommandMethods
        public override async Task OnNavigatedToAsync(NavigationContext navigationContext = null)
        {
            await SetBusyAsync(async () =>
            {
                await _familyAppService.GetPageListAsync(QueryParameter).WebAsync(dataPager.SetList);
            });
        }

        private async void InitCategories()
        {
            await SetBusyAsync(async () =>
            {
                await _categoryAppService.GetListAsync().WebAsync((categories) =>
                {
                    Categories = Map<List<CategoryListModel>>(categories.Items.Where(x => x.CategoryType == CategoryType.Major)).GenerateTree(0);
                    Tags =
                        Map<List<CategoryListModel>>(categories.Items.Where(x => x.CategoryType != CategoryType.Major)).GenerateTree(0);
                    return Task.CompletedTask;
                });
            });
        }

        [RelayCommand]
        private void CategorySelectionChanged(CategoryListModel categoryList)
        {
            MessageBox.Show(categoryList.Id.ToString());
            if (categoryList.IsChecked)
            {
                _queryParameter.CategoriesIds.Add(categoryList.Id);
            }
            else
            {
                _queryParameter.CategoriesIds.Remove(categoryList.Id);
            }
            _queryParameter.SkipCount = 0;
            OnNavigatedToAsync();
        }

        [RelayCommand]
        private void FilterTags(CategoryListModel categoryList)
        {
            var baseCategoriesIds = categoryList.GetNodeCategoriesIds();
            _queryParameter.CategoriesIds.AddRange(baseCategoriesIds);
            _queryParameter.SkipCount = 0;
            OnNavigatedToAsync();
        }

        [RelayCommand]
        public async void Search()
        {
            await OnNavigatedToAsync();
        }

        [RelayCommand]
        public async void PromptForFamilyInstancePlacement()
        {
            if (dataPager.SelectedItem is not FamilyDto familydto) return;
            if (_familyService.PromptForFamilyInstancePlacement(familydto)) return;
            //下载族后加载
            _familyAppService.DownLoadFamily(familydto.Id).WebAsync(async (bytes) =>
            {
                if (await _familyService.LoadFamily(bytes))
                {
                    //弹窗信息
                    MessageBox.Show("载入出错");
                }
            });
            _familyService.PromptForFamilyInstancePlacement(familydto);
        }
        #endregion

    }
}
