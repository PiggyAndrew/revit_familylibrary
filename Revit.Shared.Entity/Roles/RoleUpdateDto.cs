using System;

namespace Revit.Shared.Entity.Roles
{
    /// <summary>
    /// 角色更新
    /// </summary>
    public class RoleUpdateDto
    {
        public long Id { get; set; }

        public DateTime LastModificationTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 状态，0：禁用，1：正常
        /// </summary>
        public RoleStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
