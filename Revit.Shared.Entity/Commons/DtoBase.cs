using System;

namespace Revit.Shared.Entity.Commons
{
    public class DtoBase
    {
        public long Id { get; set; }

        public long CreatorId { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;

        public DateTime LastModificationTime { get; set; } = DateTime.Now;
    }
}
