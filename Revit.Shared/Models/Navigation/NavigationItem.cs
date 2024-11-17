using Prism.Mvvm;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Revit.Shared.Models
{
    public partial class NavigationItem :ObservableObject
    {
        public NavigationItem()
        { }

        public NavigationItem(
            string icon,
            string title,
            string pageViewName,
            string requiredPermissionName,
            ObservableCollection<NavigationItem> items = null)
        {
            Icon = icon;
            Title = title;
            PageViewName = pageViewName;
            RequiredPermissionName = requiredPermissionName;
            Items = items;
        }

        [ObservableProperty]
        private bool _isSelected;

        [ObservableProperty]
        private ObservableCollection<NavigationItem> _items;

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 页面名称
        /// </summary>
        public string PageViewName { get; set; }

        /// <summary>
        /// 导航参数
        /// </summary>
        public object NavigationParameter { get; set; }

        /// <summary>
        /// 权限名
        /// </summary>
        public string RequiredPermissionName { get; set; }
    }
}