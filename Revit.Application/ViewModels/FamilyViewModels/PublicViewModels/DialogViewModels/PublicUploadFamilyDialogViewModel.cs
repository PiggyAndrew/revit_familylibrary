using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Services.Dialogs;
using Prism.Commands;
using System.Collections.ObjectModel;
using Revit.Service.Services;
using Revit.Shared.Entity.Family;
using Revit.Families;
using Revit.Shared;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;

namespace Revit.Application.ViewModels.FamilyViewModels.PublicViewModels.DialogViewModels
{
    public class PublicUploadFamilyDialogViewModel : ViewModelBase, IDialogAware
    {

        #region Parameters
        public event Action<IDialogResult> RequestClose;

        private ObservableCollection<CategoryListModel> _categories = new ObservableCollection<CategoryListModel>();
        public ObservableCollection<CategoryListModel> Categories
        {
            get { return _categories; }
            set { SetProperty(ref _categories, value); }
        }

        private FamilyUploadDto _auditingFamily;

        public FamilyUploadDto AuditingFamily
        {
            get { return _auditingFamily; }
            set { SetProperty(ref _auditingFamily, value); }
        }

        public string Title => "审核族窗口";
        #endregion

        #region Commands
        private DelegateCommand<string> _submitCommand;

        public DelegateCommand<string> SubmitCommand
        {
            get => _submitCommand ?? new DelegateCommand<string>(Submit);
        }


        #endregion

        #region Methods

        private void Submit(string message)
        {
           
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }

        private async void Initial()
        {
        }
        #endregion


        public PublicUploadFamilyDialogViewModel() 
        {
        }
    }
}
