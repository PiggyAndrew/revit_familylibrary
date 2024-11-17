using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Revit.Entity.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Users
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
        public UserDto? Creator { get; set; }

        public long CreatorId { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;

        public DateTime LastModificationTime { get; set; } = DateTime.Now;

      
        public  string? PhoneNumber { get; set; }


        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 全名：姓名
        /// </summary>
        [MaxLength(20)]
        public string? FullName { get; set; }

        /// <summary>
        /// 状态，0：禁用，1：正常
        /// </summary>
        public UserStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        public string? Remark { get; set; }

        /// <summary>
        /// 角色列表
        /// </summary>
        public List<RoleDto>? Roles { get; set; }
    }
}
