using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using Revit.Categories;
using Revit.Families;
using Revit.Shared;
using Revit.Shared.Entity.Family;
using Revit.Shared.Extensions.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Abp.Application.Services.Dto;
using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Mvvm.Services;
using Revit.Service.Services;
using System;
using Prism.Commands;
using Prism.Services.Dialogs;
using System.Windows.Forms;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;
using DialogResult = Prism.Services.Dialogs.DialogResult;
using MessageBox = System.Windows.MessageBox;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels
{
    public partial class FamilyLibraryTagsViewModel : NavigationCurdViewModel
    {
        #region Properties


        private readonly ICategoryAppService _categoryAppService;

        [ObservableProperty]
        private ObservableCollection<CategoryListModel> _categories = new ObservableCollection<CategoryListModel>();
        #endregion

        public FamilyLibraryTagsViewModel(IFamilyAppService familyAppService, IFamilyService familyService, ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
            OnNavigatedToAsync();

        }

        #region Methods
        public override async Task OnNavigatedToAsync(NavigationContext navigationContext = null)
        {
            await SetBusyAsync(async () =>
            {
                await _categoryAppService.GetListAsync().WebAsync((categories) =>
                {
                    dataPager.GridModelList = Map<List<CategoryListModel>>(categories.Items).GenerateTree(0);
                    return Task.CompletedTask;
                });
            });
        }


        /// <summary>
        /// 选中组织机构-更新成员和角色信息
        /// </summary>
        /// <param name="organizationUnit"></param>
        [RelayCommand]
        private async void Selected(CategoryListModel category)
        {
            dataPager.SelectedItem = category;
        }

       

       


        [RelayCommand]
        public  async void AddCategory(CategoryListModel categoryListCreateDto = null)
        {
            IDialogResult dialogResult = new DialogResult(ButtonResult.Cancel);
            DialogParameters param = new DialogParameters();
            if (categoryListCreateDto != null)
            {
                param.Add("ParentId", categoryListCreateDto.Id);
                param.Add("ParentCategoryType", categoryListCreateDto.CategoryType);
            }


            dialogService.ShowDialog(GetPageName("Add"), param, (result =>
            {
                dialogResult = result;
            }));
            if (dialogResult.Result == ButtonResult.OK)
                await OnNavigatedToAsync();
        }

        [RelayCommand]
        private async void EditCategory(CategoryListModel category)
        {
            IDialogResult dialogResult = new DialogResult(ButtonResult.Cancel);
            DialogParameters param = new DialogParameters();
            if (category != null) param.Add("Value", category);

            dialogService.ShowDialog(GetPageName("Add"), param, (result =>
            {
                dialogResult = result;
            }));
            if (dialogResult.Result == ButtonResult.OK)
                await OnNavigatedToAsync();
        }

        [RelayCommand]
        private async void DeleteCategory(CategoryListModel categoryList)
        {
            if (MessageBox.Show("是否确定删除该分类，该分类中的所有族将清空分类，需要重新进行归类。", "提示", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                await SetBusyAsync(async () =>
                {
                    _categoryAppService.DeleteCategory(categoryList.Id).WebAsync(async (result) =>
                    {
                        await OnNavigatedToAsync();
                    });
                });
            }
        }
        #endregion

    }
}
