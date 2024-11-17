namespace Revit.WebAPI.UnitOfWork
{
    /// <summary>
    /// 工作单元特性
    /// </summary>
    public class UnitOfWorkAttribute : Attribute
    {
        /// <summary>
        /// 是否关闭事务
        /// </summary>
        public bool IsTransactional { get; set; } = true;
    }
}
