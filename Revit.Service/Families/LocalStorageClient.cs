using FileService.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Revit.Entity.Family;
using Revit.Service.Commons;
using Snowflake.Core;
using System.Reflection;

namespace Revit.Service.Families
{
    /// <summary>
    /// 用局域网内共享文件夹或者本机磁盘当备份服务器的实现类
    /// </summary>
    class LocalStorageClient : IStorageClient
    {
        private IOptionsSnapshot<LocalStorageOptions> options;
        public LocalStorageClient(IOptionsSnapshot<LocalStorageOptions> options)
        {
            this.options = options;
        }

        public StorageType StorageType => StorageType.Public;

        public async Task<Uri> SaveAsync(string fileUri, Stream content, CancellationToken cancellationToken = default)
        {
            if (fileUri.StartsWith('/'))
            {
                throw new ArgumentException("key should not start with /", nameof(fileUri));
            }
            string workingDir = options.Value.WorkingDir;
            string fullPath = Path.Combine(workingDir, fileUri);
            string? fullDir = Path.GetDirectoryName(fullPath);//get the directory
            if (!Directory.Exists(fullDir))
            {
                Directory.CreateDirectory(fullDir);
            }
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                await content.CopyToAsync(stream);
            }
            return new Uri(fullPath);
        }
    }
}
