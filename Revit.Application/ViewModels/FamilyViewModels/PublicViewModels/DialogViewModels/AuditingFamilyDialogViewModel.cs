using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services.Dialogs;
using Prism.Commands;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Revit.Shared.Entity.Family;
using Revit.Families;
using Revit.Shared.Models;
using Revit.Service.Services;
using Revit.Shared;
using Revit.Categories;
using Revit.Shared.Extensions.Threading;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;
using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Authorization.Users;
using Revit.Shared.Entity.Users;
using System.Threading.Tasks;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels.DialogViewModels
{
    public partial class AuditingFamilyDialogViewModel : DialogViewModel
    {

        #region Parameters

        [ObservableProperty]
        private ObservableCollection<object> _categories = new ObservableCollection<object>();

        [ObservableProperty]
        private ObservableCollection<object> _tags = new ObservableCollection<object>();

        [ObservableProperty]
        private FamilyDto _auditingFamily;

        public string Title => "审核族窗口";
        #endregion

        #region Commands
        private readonly ICategoryAppService _categoryAppService;

        #endregion

        public override async void OnDialogOpened(IDialogParameters parameters)
        {
            await SetBusyAsync(async () =>
            {
                if (parameters.ContainsKey("Value"))
                    AuditingFamily = parameters.GetValue<FamilyDto>("Value");

                await _categoryAppService.GetListAsync().WebAsync((categories) =>
                {
                    Categories = Map<List<CategoryListModel>>(categories.Items.Where(x => x.CategoryType == CategoryType.Major)).GenerateTree(0);

                    Tags =
                        Map<List<CategoryListModel>>(categories.Items.Where(x => x.CategoryType != CategoryType.Major)).GenerateTree(0);
                    return Task.CompletedTask;
                });
            });
        }

        public AuditingFamilyDialogViewModel(ICategoryAppService categoryAppService)
        {
            this._categoryAppService = categoryAppService;
        }
    }
}
