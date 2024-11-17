using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.ViewModels
{
    public partial class ValidatorViewModelBase : ObservableValidator, IDialogAware
    {
        public string Title { get; set; }

        public event Action<IDialogResult> RequestClose;

        public virtual bool CanCloseDialog() => true;

        public void OnDialogClosed() { }

        public void OnDialogClosed(ButtonResult result)
        {
            RequestClose?.Invoke(new DialogResult(result));
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        { }


        [RelayCommand]
        public virtual async Task Save()
        {
            OnDialogClosed(ButtonResult.OK);
            await Task.CompletedTask;
        }

        [RelayCommand]
        public virtual void Cancel() => OnDialogClosed(ButtonResult.Cancel);
    }

       
}
