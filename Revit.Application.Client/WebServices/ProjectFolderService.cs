using Revit.Service.ApiServices;
using Revit.Service.IServices;
using Revit.Shared.Entity.Commons;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Web.Models;
using Revit.Project.Dto;

namespace Revit.Service.Services
{
    public class ProjectFolderService : BaseService<ProjectFolderDto>, IProjectFolderService
    {
        public ProjectFolderService(MyHttpClient client) : base(client)
        {
            ServiceName = "Folder";
        }

        public async Task<AjaxResponse<IEnumerable<ProjectFolderDto>>> GetFolders(long projectId, ProjectGetFoldersDto projectRequestFolderDto)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/Project/{projectId}/{ServiceName}" +
                $"?requestPath={projectRequestFolderDto.RequestPath}";
            return await client.ExecuteAsync<IEnumerable<ProjectFolderDto>>(request);
        }

        public async Task<AjaxResponse<ProjectFolderDto>> CreateFolder(long projectId, ProjectCreateFolderDto projectRequestFolderDto)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Post;
            request.Route = $"api/Project/{projectId}/Folder";
            request.Parameter = projectRequestFolderDto;
            return await client.ExecuteAsync<ProjectFolderDto>(request);
        }

      
    }



}
