using Revit.Entity.Project;

namespace Revit.Service.Projects
{
    public interface IProjectFileService
    {
        Task<IEnumerable<ProjectFolderDto>> UploadProjectFile(long folderId,long userId, ProjectUploadFileDto projectUploadFileDto);
        Task<FileStream> GetRvtGltfFile(long folderId);
    }
}