using Revit.Authorization.Permissions.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Revit.Admin.Services
{
    /// <summary>
    /// 权限树生成接口
    /// </summary>
    public interface IPermissionTreesService
    {
        void CreatePermissionTrees(List<FlatPermissionDto> permissions, List<string> grantedPermissionNames);

        List<string> GetSelectedItems();

        ObservableCollection<object> SelectedItems { get; set; } 
    }
}
