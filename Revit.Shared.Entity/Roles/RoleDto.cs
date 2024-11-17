using Revit.Shared.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Commons;

namespace Revit.Shared.Entity.Roles
{
    /// <summary>
    /// 角色信息
    /// </summary>
    public class RoleDto:DtoBase
    {
        /// <summary>
        /// 创建者
        /// </summary>
        public UserDto Creator { get; set; } = null;

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

        public bool IsAssigned { get; set; }
    }
}
