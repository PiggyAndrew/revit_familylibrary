using Microsoft.AspNetCore.Http;

namespace Revit.Shared.Entity.Project
{
    public class ProjectPostPutDto
    {

        public long CreatorId { get; set; }

        public string ProjectName { get; set; } = "";

        public string ProjectAddress { get; set; } = "";

        /// <summary>
        /// 项目介绍
        /// </summary>
        public string Introduction { get; set; } = "";

        public string Icon { get; set; }
    }
}
