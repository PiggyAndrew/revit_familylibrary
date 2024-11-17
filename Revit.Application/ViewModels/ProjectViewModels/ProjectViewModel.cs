using System.Collections.ObjectModel;
using Revit.Application.Views.ProjectViews;
using Prism.Commands;
using Prism.Regions;
using Revit.Shared;

namespace Revit.Application.ViewModels.ProjectViewModels
{
    public class ProjectViewModel : ViewModelBase
    {
        private ObservableCollection<MenuBar> _menuBars = new ObservableCollection<MenuBar>() {
        new MenuBar() { Icon = "FloderManage", Title = "文件夹管理", NameSpace = nameof(ProjectFileManageView) },
        new MenuBar() { Icon = "Member", Title = "成员", NameSpace = nameof(ProjectMemberView) },
        };
        public ObservableCollection<MenuBar> MenuBars
        {
            get { return _menuBars; }
            set { SetProperty(ref _menuBars, value); }
        }
        private readonly IRegionManager regionManager;


        protected  void Navigate(MenuBar menuBar)
        {
            if (menuBar != null && !string.IsNullOrWhiteSpace(menuBar.NameSpace))
            {
                regionManager.RequestNavigate("ProjectDetailContent", menuBar.NameSpace);
            }
        }

        public ProjectViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            //初始文件管理
            this.regionManager.RegisterViewWithRegion("ProjectDetailContent", typeof(ProjectFileManageView));
        }



    }
}