using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Users;
using System;
using System.Collections.Generic;

namespace Revit.Shared.Entity.Family
{
    public class FamilyDto : DtoBase
    {
        public string Name { get; set; } = "";

        public string FileExtension { get; set; } = "";

        public long FileBytesSize { get; set; }

        public string FileSHA256Hash { get; private set; } = "";

        public long SameFileKey { get; set; }

        public int Version { get; set; } = 1;

        public Uri MainPhotoUrl { get; set; }

        public byte[] MainPhotoBytes { get; set; } = null;

        public FamilyAuditStatus FamilyAuditStatus { get; set; } = FamilyAuditStatus.Auditing;

        public UserDto Creator { get; set; }


        public IEnumerable<long> CategoriesIds { get; set; } = new List<long>();
    }

}