using System;
using System.Collections.Generic;
using System.Text;

namespace Revit.Shared.Entity.Permissions
{
    /// <summary>
    /// 权限类型
    /// </summary>
    public enum PermissionType
    {
        /// <summary>
        /// 菜单
        /// </summary>
        Menu,

        /// <summary>
        /// 按钮/功能
        /// </summary>
        Element,

        /// <summary>
        /// API接口
        /// </summary>
        API
    }

    /// <summary>
    /// 权限状态
    /// </summary>
    public enum PermissionStatus
    {
        /// 已禁用
        /// </summary>
        Forbidden = 0,
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 1
    }
}
