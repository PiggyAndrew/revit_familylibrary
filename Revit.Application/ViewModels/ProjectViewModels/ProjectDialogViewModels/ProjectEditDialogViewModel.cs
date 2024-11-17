using Prism.Services.Dialogs;
using Revit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Application.ViewModels.ProjectViewModels.ProjectDialogViewModels
{
    public class ProjectEditDialogViewModel : ViewModelBase, IDialogAware
    {
        public ProjectEditDialogViewModel( )
        {
        }

        public string Title => "项目创建窗口";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            throw new NotImplementedException();
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
