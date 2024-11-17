using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Revit.Entity.Family
{
    public class R_Family : R_File
    {

        [Comment("族主图")]
        public Uri MainPhotoUrl { get; set; }

        [Comment("族状态")]
        public FamilyAuditStatus FamilyAuditStatus { get; set; } = FamilyAuditStatus.Auditing;

        public static R_Family Create(long creatorId, long id, long sameFileKey, long fileSizeInBytes, string fileName, string fileSHA256Hash, Uri familyUrl, Uri imageUrl)
        {
            R_Family item = new R_Family()
            {
                Id = id,
                FileSHA256Hash= fileSHA256Hash,
                SameFileKey = sameFileKey,
                Name = fileName,
                FileExtension = Path.GetExtension(fileName),
                SaveUrl = familyUrl,
                MainPhotoUrl = imageUrl,
                FileBytesSize = fileSizeInBytes,
                CreatorId = creatorId
            };
            return item;
        }

        
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