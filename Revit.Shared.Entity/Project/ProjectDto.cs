using Revit.Accounts.Dto;
using System;

namespace Revit.Shared.Entity.Project
{
    public class ProjectDto
    {
        public string ProjectName { get; set; }

        public long Id { get; set; }

        public long CreatorId { get; set; }


        public DateTime CreationTime { get; set; } = DateTime.Now;

        public DateTime LastModificationTime { get; set; } = DateTime.Now;

        public LoginedUserDto UserDto { get; set; }

        public int ProjectUserCount { get; set; }

        public double DocumentsSize { get; set; }

        public string BasePath { get; set; }
    }
}