using Revit.Shared.Entity.Commons;
using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Web.Models;
using Revit.Shared.Entity.Project;

namespace Revit.Service.IServices
{
    public interface IProjectFileService
    {
        Task<AjaxResponse<IEnumerable<ProjectFolderDto>>> UploadFilesAsync(long folderId, UploadFileDtoBase projectUploadFileDto);
    }
}