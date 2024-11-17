using Revit.Entity.Project;
using Revit.Entity.Users;

namespace Revit.Service.Projects
{
    public interface IProjectService
    {
        Task<ProjectResponseDto> CreateProject(ProjectPostPutDto createDto);
        int DeleteProject(long projectId);
        IEnumerable<ProjectResponseDto> GetProjects(ProjectRequestDto projectRequestDto);
        IEnumerable<UserDto> GetProjectUsers(long projectId);
        Task<IEnumerable<ProjectFolderDto>> GetRecentlyFiles(long userId);

        int DeleteProjectUser(long projectId, long userId);

        UserDto AddProjectUser(long projectId, long userId);
        int ModifyProject(ProjectPostPutDto projectModify);

    }
}