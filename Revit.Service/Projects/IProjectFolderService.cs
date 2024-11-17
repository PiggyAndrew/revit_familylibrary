using Revit.Entity.Project;

namespace Revit.Service.Projects
{
    public interface IProjectFolderService
    {
        ProjectFolderDto CreateProjectFolder(long projectId, ProjectCreateFolderDto createFolderDto);
        List<ProjectFolderDto> GetProjectPathFolders(long projectId, ProjectGetFoldersDto projectGetFileDto);

        int DeleteProjectFolder(long folderId);
    }
}