using System;
using System.Collections.Generic;
using System.Text;

namespace Revit.Shared.Entity.Family
{
    public enum CategoryType
    {
        Major,
        ElementType,
        Software,
        Producer,
        Property,
        Keyword
    }

    /// <summary>
    /// 族状态
    /// </summary>
    public enum FamilyAuditStatus
    {
        /// <summary>
        /// 重新上传
        /// </summary>
        Auditing = 0,
        /// <summary>
        /// 通过
        /// </summary>
        Pass = 1,
        /// <summary>
        /// 未通过
        /// </summary>
        NotPass = 2,
        /// <summary>
        /// 审核中
        /// </summary>
        Retry = 3
    }
}
