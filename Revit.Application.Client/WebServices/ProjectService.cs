using Revit.Service.ApiServices;
using Revit.Service.IServices;
using Revit.Shared.Entity.Commons;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Abp.Web.Models;
using Revit.Project.Dto;
using Revit.Shared.Entity.Users;

namespace Revit.Service.Services
{
    public class ProjectService : BaseService<ProjectDto>, IProjectService
    {
        public ProjectService(MyHttpClient client) : base(client)
        {
            this.ServiceName = "Projects";
        }


        public async Task<AjaxResponse<IEnumerable<ProjectDto>>> GetProjects(ProjectPageRequestDto queryParameter)
        {
            BaseRequest request = new BaseRequest();
            //request.Method = HttpMethod.Get;
            //request.Route = $"api/{ServiceName}?pageIndex={queryParameter.PageIndex}" +
            //    $"&&pageSize={queryParameter.PageSize}" +
            //    $"&&userId={queryParameter.UserId}" +
            //    $"&&searchMessage={queryParameter.SearchMessage}";
            return await client.ExecuteAsync<IEnumerable<ProjectDto>>(request);
        }


        public async Task<AjaxResponse<ProjectDto>> Create(ProjectPostPutDto createDto)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Post;
            request.Route = $"api/{ServiceName}";
            if (!string.IsNullOrWhiteSpace(createDto.Icon))
            {
                request.FilePaths = new List<string>() { createDto.Icon };
            }
            request.ContentType = ContentType.FormData;
            request.FormDatas = new Dictionary<string, string>
            {
                { "ProjectName", createDto.ProjectName },
                { "ProjectAddress", createDto.ProjectAddress },
                { "Introduction", createDto.Introduction },
                { "CreatorId", createDto.CreatorId.ToString() }
            };
            return await client.ExecuteAsync<ProjectDto>(request);
        }

        public async Task<AjaxResponse> Delete(long projectId)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Delete;
            request.Route = $"api/{ServiceName}/{projectId}";
            return await client.ExecuteAsync(request);
        }


        public async Task<AjaxResponse<IEnumerable<ProjectFolderDto>>> GetRecentlyFiles(long userId)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/{ServiceName}?userId={userId}";
            return await client.ExecuteAsync<IEnumerable<ProjectFolderDto>>(request);
        }


        public async Task<AjaxResponse<IEnumerable<UserDto>>> GetUsers(long projectId)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/{ServiceName}/{projectId}/Users";
            return await client.ExecuteAsync<IEnumerable<UserDto>>(request);
        }

        public async Task<AjaxResponse> DeleteUser(long projectId,long userId)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Delete;
            request.Route = $"api/{ServiceName}/{projectId}/Users/{userId}";
            return await client.ExecuteAsync(request);
        }

        Task<AjaxResponse<IEnumerable<UserDto>>> IProjectService.GetUsers(long projectId)
        {
            throw new System.NotImplementedException();
        }
    }
}
