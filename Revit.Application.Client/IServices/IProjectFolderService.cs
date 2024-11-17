using Revit.Shared.Entity.Commons;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Web.Models;
using Revit.Shared.Entity.Project;

namespace Revit.Service.IServices
{
    public interface IProjectFolderService
    {
        Task<AjaxResponse<ProjectFolderDto>> CreateFolder(long projectId, ProjectCreateFolderDto projectCreateFolderDto);
        Task<AjaxResponse<IEnumerable<ProjectFolderDto>>> GetFolders(long projectId, ProjectGetFoldersDto projectRequestFolderDto);
    }
}