using Revit.Shared.Entity.Commons;
using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Web.Models;
using Revit.Shared.Entity.Project;
using Revit.Shared.Entity.Users;

namespace Revit.Service.IServices
{
    public interface IProjectService
    {
        Task<AjaxResponse<IEnumerable<ProjectDto>>> GetProjects(ProjectPageRequestDto pagedList);
        Task<AjaxResponse<ProjectDto>> Create(ProjectPostPutDto createDto);
        Task<AjaxResponse> Delete(long projectId);

        Task<AjaxResponse<IEnumerable<ProjectFolderDto>>> GetRecentlyFiles(long userId);

        Task<AjaxResponse<IEnumerable<UserDto>>> GetUsers(long projectId);
        Task<AjaxResponse> DeleteUser(long projectId, long userId);
    }
}
