using Revit.Shared.Entity.Roles;
using System;
using System.Collections.Generic;

namespace Revit.Shared.Entity.Users
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserDto
    {
        public long Id { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public UserDto Creator { get; set; } = null;

        public long CreatorId { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;

        public DateTime LastModificationTime { get; set; } = DateTime.Now;


        public string PhoneNumber { get; set; }


        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 全名：姓名
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 状态，0：禁用，1：正常
        /// </summary>
        public UserStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        public List<RoleDto> Roles { get; set; } = new List<RoleDto>();
    }
}
