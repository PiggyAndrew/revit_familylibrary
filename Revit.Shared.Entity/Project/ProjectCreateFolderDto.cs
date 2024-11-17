using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Project
{
    public class ProjectCreateFolderDto
    {
        /// <summary>
        /// 创建人Id
        /// </summary>
        public long CreatorId { get; set; }


        /// <summary>
        /// 请求根目录Id
        /// </summary>
        public long FolderId { get; set; }


        /// <summary>
        /// 文件夹名称
        /// </summary>
        public string FolderName { get; set; }

    }
}
