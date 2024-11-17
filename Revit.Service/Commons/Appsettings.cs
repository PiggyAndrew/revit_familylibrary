using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.Commons
{
    public static class Appsettings
    {
        /// <summary>
        /// 上传文件存储根路径
        /// </summary>
        public static string BasePath = "UploadFiles";

        /// <summary>
        /// 项目文件存储路径
        /// </summary>
        public static string BasePath_Project_Public = Path.Combine(BasePath, "Public", "Projects");

        /// <summary>
        /// 项目文件存储路径
        /// </summary>
        public static string BasePath_Family_Public = Path.Combine(BasePath, "Public", "Famliies");

    }
}
