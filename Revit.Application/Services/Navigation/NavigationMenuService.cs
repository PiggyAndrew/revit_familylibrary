using System.Collections.Generic;
using System.Collections.ObjectModel;
using AppFramework.Admin.Services;
using Revit.Application.Services.Navigation;
using Revit.Application.Views.FamilyViews.PublicViews;
using Revit.Application.Views.UserViews;
using Revit.Shared.Consts;
using Revit.Shared.Models;
using Revit.Shared.Services.Permission;

namespace Revit.Application.Services
{
    public class NavigationMenuService : INavigationMenuService
    {
        private ObservableCollection<NavigationItem> GetMenuItems()
        {
            return new ObservableCollection<NavigationItem>()
            {
                new NavigationItem("publicLibrary","公共族库",nameof(FamilyLibraryPublicView),""),

               new NavigationItem("user","用户管理","","",new ObservableCollection<NavigationItem>()
               {
                      new NavigationItem("account","账户管理", nameof(UserView), ""),
                      new NavigationItem("role","角色管理", nameof(RoleView), ""),
               }),
               new NavigationItem("familyManager","族库管理","","",new ObservableCollection<NavigationItem>()
               {
                   new NavigationItem("upload","公共族库族上传", nameof(FamilyLibaryPublicUploadView), ""),
                   new NavigationItem("audit","公共族库族审核", nameof(FamilyLibraryPublicAuditView), ""),
                   new NavigationItem("tags","公共族库族标签管理", nameof(FamilyLibraryTagsView), ""),
               }),

            };
        }

        ///// <summary>
        ///// 获取权限菜单
        ///// </summary>
        ///// <param name="grantedPermissions"></param>
        ///// <returns></returns>
        //public ObservableCollection<NavigationItem> GetAuthMenus(Dictionary<string, string> permissions)
        //{
        //    var navigationItems = GetMenuItems();
        //    var authorizedMenuItems = new ObservableCollection<NavigationItem>();
        //    foreach (var item in navigationItems)
        //    {
        //        //转换特定地区语言的标题
        //        item.Title = Local.Localize(item.Title);

        //        if (CheckPressions(item.RequiredPermissionName))
        //        {
        //            if (item.Items != null)
        //            {
        //                var subItems = new ObservableCollection<NavigationItem>();

        //                foreach (var submenuItem in item.Items)
        //                {
        //                    if (CheckPressions(submenuItem.RequiredPermissionName))
        //                    {
        //                        submenuItem.Title = Local.Localize(submenuItem.Title);
        //                        subItems.Add(submenuItem);
        //                    }
        //                }

        //                item.Items = subItems;
        //            }

        //            authorizedMenuItems.Add(item);
        //        }
        //    }
        //    return authorizedMenuItems;

        //    bool CheckPressions(string requiredPermissionName)
        //    {
        //        if (string.IsNullOrWhiteSpace(requiredPermissionName) ||
        //           (permissions != null && permissions.ContainsKey(requiredPermissionName)))
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //}
        public ObservableCollection<NavigationItem> GetAuthMenus(Dictionary<string, string> permissions)
        {
            return GetMenuItems();
        }
    }
}