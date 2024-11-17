using System.Windows;
using Prism.Services.Dialogs;

namespace Revit.Application.Views
{
    /// <summary>
    /// DefaultDialog.xaml 的交互逻辑
    /// </summary>
    public partial class DefaultDialog : Window,IDialogWindow
    {
        public DefaultDialog()
        {
            InitializeComponent();

            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        public IDialogResult Result { get; set; }
    }
}
