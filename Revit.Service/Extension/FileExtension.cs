using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Service.Extension
{
    public static class FileExtension
    {
        public static string ConvertFileSize(long fileSize)
        {
            const long KB = 1024;
            const long MB = KB * 1024;
            const long GB = MB * 1024;

            if (fileSize < KB)
                return $"{fileSize} B";
            else if (fileSize < MB)
                return $"{Math.Round(d: fileSize / KB, 2)} KB";
            else if (fileSize < GB)
                return $"{Math.Round(d: fileSize / MB, 2)} MB";
            else
                return $"{Math.Round(d: fileSize / GB, 2)} GB";
        }
    }
}
