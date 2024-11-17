using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Revit.Application.Views.ProjectViews
{
    /// <summary>
    /// FileManageView.xaml 的交互逻辑
    /// </summary>
    public partial class ProjectFileManageView : UserControl
    {
        public ProjectFileManageView()
        {
            InitializeComponent();
        }

        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
            //目标
            this.contextMenu.PlacementTarget = this.btnMenu;
            //位置
            this.contextMenu.Placement = PlacementMode.Top;
            //显示菜单
            this.contextMenu.IsOpen = true;
        }

        private void btnMenu_Initialized(object sender, EventArgs e)
        {
            this.btnMenu.ContextMenu = null;
        }
    }
}
