using System.Linq;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using Prism.Regions;
using Revit.Admin;
using Revit.Shared.Consts;
using Revit.Shared.Extensions;

namespace Revit.Application.Services.Navigation
{
    [INotifyPropertyChanged]
    public partial class NavigationService 
    {
        private readonly IRegionManager _regionManager;
        private IRegion NavigationRegion => _regionManager.Regions[AppRegions.Main];

        [ObservableProperty]
        private int _selectedIndex;

       
        public NavigationService(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        public void Navigate(string pageName, NavigationParameters navigationParameters = null)
        {
            if (string.IsNullOrWhiteSpace(pageName)) return;

            var view = NavigationRegion.Views.FirstOrDefault(q => q.GetType().Name.Equals(pageName));
            if (view == null)
            {
                NavigationRegion.RequestNavigate(pageName, NavigateionCallBack, navigationParameters);
            } 
            else
            {
                SelectedIndex = NavigationRegion.Views.IndexOf(view);
            }
        }

        public void RemoveView(object view)
        {
            if (NavigationRegion.Views.Contains(view))
            {
                /*
                 * 关闭Tab后调用OnNavigatedFrom，如需手动释放资源请在 OnNavigatedFrom 中处理
                 */
                if (view is UserControl viewControl && viewControl.DataContext is INavigationAware navigationAware)
                    navigationAware.OnNavigatedFrom(null);

                NavigationRegion.Remove(view);
            }
        }

        public void RemoveView(string pageName)
        {
            var view = NavigationRegion.Views.FirstOrDefault(q => q.GetType().Name.Equals(pageName));
            if (view != null)
            {
                /*
                 * 关闭Tab后调用OnNavigatedFrom，如需手动释放资源请在 OnNavigatedFrom 中处理
                 */
                if (view is UserControl viewControl && viewControl.DataContext is INavigationAware navigationAware)
                    navigationAware.OnNavigatedFrom(null);

                NavigationRegion.Remove(view);
            }
        }

        private void NavigateionCallBack(NavigationResult navigationResult)
        {
            if (navigationResult.Result != null && !(bool)navigationResult.Result)
            {
#if DEBUG
                System.Diagnostics.Debug.WriteLine(navigationResult.Error.Message);
#endif

                AppLogs.Error(navigationResult.Error);
            }
            else
            {
                SelectedIndex = NavigationRegion.Views.Count() - 1;
            }
        }
    }
}
