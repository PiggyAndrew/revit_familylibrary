using Microsoft.EntityFrameworkCore;
using Revit.Entity.Commons;
using Revit.Shared.Entity.Permissions;
using System.ComponentModel.DataAnnotations;

namespace Revit.Entity.Permissions
{
    [Index(nameof(Sort))]
    [Index(nameof(ParentId))]
    [Index(nameof(Code), IsUnique = true)]
    public class R_Permission : R_Entity
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        [MaxLength(20)]
        [Comment("权限名称")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 权限编码
        /// </summary>
        [MaxLength(100)]
        [Comment("权限编码")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Url地址
        /// </summary>
        [MaxLength(200)]
        [Comment("Url地址")]
        public string? Url { get; set; }

        /// <summary>
        /// Vue页面组件
        /// </summary>
        [MaxLength(200)]
        [Comment("Vue页面组件")]
        public string? Component { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        [MaxLength(100)]
        [Comment("图标")]
        public string? Icon { get; set; }

        /// <summary>
        /// 菜单类型：菜单权限、元素权限、Api权限、数据权限
        /// </summary>
        [Comment("菜单类型,0：菜单权限、元素权限、Api权限、数据权限")]
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// API方法
        /// </summary>
        [MaxLength(10)]
        [Comment("API方法：GET、PUT、POST、DELETE")]
        public string? ApiMethod { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Comment("排序")]
        public int Sort { get; set; }

        /// <summary>
        /// 父菜单Id
        /// </summary>
        [Comment("父菜单Id")]
        public long ParentId { get; set; }

        /// <summary>
        /// 状态，0：禁用，1：正常
        /// </summary>
        [Comment("状态，0：禁用，1：正常")]
        public PermissionStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        [Comment("备注")]
        public string? Remark { get; set; }
    }

   
}
