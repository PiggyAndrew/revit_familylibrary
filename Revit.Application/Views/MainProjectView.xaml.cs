using Prism.Ioc;
using Prism.Regions;
using Revit.Shared;
using Revit.Shared.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Revit.Application.Views
{
    /// <summary>
    /// MainProjectView.xaml 的交互逻辑
    /// </summary>
    public partial class MainProjectView : UserControl
    {

        public MainProjectView()
        {
            InitializeComponent();
            RegionManager.SetRegionManager(this, ContainerLocator.Container.Resolve<IRegionManager>());
            RegionManager.UpdateRegions();

            //regionManager.RegisterViewWithRegion("ProjectContent", typeof(ProjectView));
        }


    }
}
