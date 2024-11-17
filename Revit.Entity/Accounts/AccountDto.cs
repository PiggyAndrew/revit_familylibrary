using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Accounts
{
    /// <summary>
    /// 登录账号信息
    /// </summary>
    public class AccountDto
    {
        /// <summary>
        /// 角色列表
        /// </summary>
        public string[] Roles { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 介绍
        /// </summary>
        public string Introduction { get; set; }


        public long UserId { get; set; }

        public string Account { get; set; }

        public string UserName { get; set; }

        public string UserPhoneNumber { get; set; }

    }
}
