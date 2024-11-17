namespace Revit.Shared.Entity.Roles
{
    /// <summary>
    /// 角色创建
    /// </summary>
    public class RoleCreateDto
    {
        public long Id { get; set; }

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
