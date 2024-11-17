using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Accounts
{
    /// <summary>
    /// 账户更新密码
    /// </summary>
    public   class AccountUpdatePasswordDto
    {
        /// <summary>
        /// 原本密码
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string OldPassword { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 6)]
        public string NewPassword { get; set; }
    }
}
