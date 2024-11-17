using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Revit.Entity.Users
{
    public class R_User : IdentityUser<long>
    {
        [Comment("创建者Id")]
        public long CreatorId { get; set; }

        [Comment("创建时间")]
        public DateTime CreationTime { get; set; } = DateTime.Now;

        [Comment("最后编辑时间")]
        public DateTime LastModificationTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 全名：姓名
        /// </summary>
        [MaxLength(20)]
        public string FullName { get; set; }

        /// <summary>
        /// 状态，0：禁用，1：正常
        /// </summary>
        public UserStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        public string Remark { get; set; }


        public static async Task<R_User?> GetCurrentUser(IHttpContextAccessor httpContextAccessor
            , UserManager<R_User> userManager)
        {
            var userName = httpContextAccessor.HttpContext?.User.Identity?.Name;
            var result = await userManager.FindByNameAsync(userName);
            return result;
        }
    }

    public enum UserStatus
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
