using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity.Commons
{
    /// <summary>
    /// entity基类
    /// </summary>
    public class R_File : R_Entity
    {
        [Comment("文件名称无后缀")]
        public string Name { get; set; } = "";

        [Comment("后缀名称")]
        public string FileExtension { get; set; } = "";


        [Comment("文件大小")]
        public long FileBytesSize { get; set; }

        [Comment("散列值，用于区分内容不同，即不完全相同的文件")]
        public string FileSHA256Hash { get;  set; } = "";

        [Comment("不同版本但文件相同的标识")]
        public long SameFileKey { get; set; }

        [Comment("版本号")]
        public int Version { get; set; } = 1;

        [Comment("本地存储路径")]
        public Uri SaveUrl { get; set; } = null;


        [Comment("备份路径")]
        public Uri BackUpUrl { get; set; } = null;
    }
}
