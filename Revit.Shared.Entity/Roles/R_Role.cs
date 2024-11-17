using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Roles
{
    public class R_Role : IdentityRole<long>
    {
        /// <summary>
        /// 角色
        /// </summary>
        [Comment("创建者Id")]
        public long CreatorId { get; set; }

        [Comment("创建时间")]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        [Comment("最后编辑时间")]
        public DateTime LastModificationTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 状态，0：禁用，1：正常
        /// </summary>
        [Comment("状态，0：禁用，1：正常")]
        public RoleStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        [Comment("备注")]
        public string Remark { get; set; }


    }

    /// <summary>
    /// 角色状态
    /// </summary>
    public enum RoleStatus
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
