using Prism.Services.Dialogs;
using System.Windows;
using System.Collections.ObjectModel;
using Revit.Shared.Entity.Family;
using Revit.Shared.Models;
using Revit.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Revit.Categories;
using Revit.Shared.Extensions.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Linq;
using Revit.Families;
using Revit.Shared.Entity.Categories;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels.DialogViewModels
{
    public partial class AddFamilyLibraryTagsDialogViewModel : DialogViewModel
    {

        #region Parameters
        public bool IsNew { get; set; }

        public long ParentId { get; set; }
        public CategoryType ParentCategoryType { get; set; }


        private readonly ICategoryAppService _categoryAppService;

        [ObservableProperty] public Visibility _categoryTypeVisibility = Visibility.Collapsed;

        [ObservableProperty]
        private CategoryForEditModel _model;

        [ObservableProperty]
        private ComboboxItems<CategoryType> _categoryTypeOptions = new ComboboxItems<CategoryType>() { Items = new ObservableCollection<CategoryType>(new List<CategoryType>() { CategoryType.ElementType, CategoryType.Software, CategoryType.Property, CategoryType.Major, CategoryType.Keyword }) };

        public string Title => "添加标签";
        #endregion


        #region Methods



        public override async Task Save()
        {
            var validatorResult = Verify(Model);
            if (!validatorResult.IsValid)
            {

                MessageBox.Show(validatorResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault());
                return;
            };

            await SetBusyAsync(async () =>
            {
                if (IsNew)
                {
                    var categoryCreateDto = Map<CategoryCreateDto>(Model);
                    categoryCreateDto.ParentId = ParentId;
                    await _categoryAppService.AddCategory(categoryCreateDto).WebAsync(base.Save);
                }
                else
                {
                    await _categoryAppService.UpdateCategory(Map<CategoryPutDto>(Model)).WebAsync(base.Save);
                }
            });
        }


        public override void OnDialogOpened(IDialogParameters parameters)
        {
            var editModel = parameters.GetValue<CategoryListModel>("Value");
            if (editModel == null) IsNew = true;
            Model = Map<CategoryForEditModel>(editModel) ?? Map<CategoryForEditModel>(new CategoryForEditModel());

            if (parameters.ContainsKey("ParentId"))
            {
                ParentId = parameters.GetValue<long>("ParentId");
            }
            else if (IsNew)
            {
                CategoryTypeVisibility = Visibility.Visible;
            }

            if (Model.ParentId == 0)
            {
                CategoryTypeVisibility = Visibility.Visible;
            }

            if (parameters.ContainsKey("ParentCategoryType"))
            {
                Model.CategoryType = parameters.GetValue<CategoryType>("ParentCategoryType");
            }
        }


        #endregion


        public AddFamilyLibraryTagsDialogViewModel(ICategoryAppService categoryAppService) : base()
        {
            _categoryAppService = categoryAppService;
        }
    }
}
