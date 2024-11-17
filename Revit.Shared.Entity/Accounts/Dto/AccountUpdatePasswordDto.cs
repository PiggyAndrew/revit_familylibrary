namespace Revit.Shared.Entity.Accounts.DTO
{
    /// <summary>
    /// 账户更新密码
    /// </summary>
    public class AccountUpdatePasswordDto
    {
        /// <summary>
        /// 原本密码
        /// </summary>
        public string OldPassword { get; set; }

        /// <summary>
        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }
    }
}
