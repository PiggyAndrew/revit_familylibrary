using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Revit.Mvvm.Interface;
using Revit.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows;
using Application = Autodesk.Revit.ApplicationServices.Application;

namespace Revit.Shared.Base
{
    public abstract class RevitViewModelBase : BindableBase
    {
        private DelegateCommand<MenuBar> _navigateCommand;

        public DelegateCommand<MenuBar> NavigateCommand
        { get => _navigateCommand ?? new DelegateCommand<MenuBar>(Navigate); }

        private DelegateCommand _changeNextPageCommand;

        public DelegateCommand ChangeNextPageCommand
        { get => _changeNextPageCommand ?? new DelegateCommand(ChangeNextPage); }

        private DelegateCommand _changePreviousPageCommand;

        public DelegateCommand ChangePreviousPageCommand
        { get => _changePreviousPageCommand ?? new DelegateCommand(ChangePreviousPage); }

        private RelayCommand<Window> _closeCommand;

        public RelayCommand<Window> CloseCommand { get => _closeCommand ?? new RelayCommand<Window>(CloseWindow); }

        private DelegateCommand _searchCommand;
        public DelegateCommand SearchCommand
        { get => _searchCommand ?? new DelegateCommand(Search); }


        private DelegateCommand _submitCommand;

        public DelegateCommand SubmitCommand
        {
            get => _submitCommand ?? new DelegateCommand(Submit);
        }

        protected virtual void Submit()
        {

        }

        protected virtual void ChangePreviousPage()
        {
        }

        protected virtual void Search()
        {
        }

        protected virtual void Navigate(MenuBar menuBar)
        {
        }

        protected virtual void ChangeNextPage()
        {
        }

        protected virtual void CloseWindow(Window window)
        {
            window.Close();
        }


        ///// <summary>
        ///// 实体验证器方法
        ///// </summary>
        ///// <typeparam name="T">验证结果</typeparam>
        ///// <param name="model">验证实体</param>
        ///// <returns></returns>
        //public virtual ValidationResult Verify<T>(T model, bool ShowError = true)
        //{
        //    var validationResult = validator.Validate(model);

        //    if (!validationResult.IsValid && ShowError)
        //    {
        //        StringBuilder stringBuilder = new StringBuilder();
        //        foreach (var item in validationResult.Errors)
        //        {
        //            stringBuilder.AppendLine(item.ErrorMessage);
        //        }
        //        //AppDialogHelper.Warn(stringBuilder.ToString());
        //    }
        //    return validationResult;
        //}

        public RevitViewModelBase(IDataContext dataContext)
        {
            _dataContext = dataContext;
            _document = dataContext.Document;
            _uiDocument = dataContext.GetUIDocument();
            _uiApplication = dataContext.GetUIApplication();
            _application = dataContext.GetApplication();
        }

        //private readonly IGlobalValidator validator;
        protected readonly IDataContext _dataContext;
        protected readonly Document _document;
        protected readonly UIDocument _uiDocument;
        protected readonly UIApplication _uiApplication;
        protected readonly Autodesk.Revit.ApplicationServices.Application _application;

    }
}
