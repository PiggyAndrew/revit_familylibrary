using Newtonsoft.Json;
using Revit.Shared.Entity.Commons.Desensitization;
using System;
using System.Collections.Generic;

namespace Revit.Shared.Entity.Users
{
    public class UserUpdateDto
    {  /// <summary>
       /// 密码
       /// </summary>
        [JsonConverter(typeof(DesensitizationConvter), 2, 4)]
        public string Password { get; set; }

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
        /// 角色列表
        /// </summary>
        public List<string> RoleNames { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
