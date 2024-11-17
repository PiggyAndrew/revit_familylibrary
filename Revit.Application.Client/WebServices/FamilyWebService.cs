using Revit.Entity.Entity;
using Revit.Entity.Entity.Parameters;
using Revit.Service.ApiServices;
using Revit.Service.IServices;
using Revit.Service.Services;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Commons.Page;
using Revit.Shared.Entity.Family;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Revit.Application.ViewModels.FamilyViewModels
{
    public class FamilyWebService : BaseService<FamilyDto>, IFamilyWebService
    {
        public FamilyWebService(MyHttpClient client) : base(client)
        {
            ServiceName = "Family";
        }


        public async Task<ApiResponse<IEnumerable<FamilyDto>>> GetUploadedFamilies(long userId)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/{ServiceName}/User/{userId}";
            return await client.ExecuteAsync<IEnumerable<FamilyDto>>(request);
        }


        public async Task<ApiResponse<PagedList<FamilyDto>>> GetPageListAsync(FamilyPageRequestDto parameter)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/{ServiceName}?pageIndex={parameter.PageIndex}" +
                $"&pageSize={parameter.PageSize}" +
                $"&CategoriesIds={parameter.CategoriesIds}" +
                $"&searchMessage={parameter.SearchMessage}";
            return await client.ExecuteAsync<PagedList<FamilyDto>>(request);
        }

        public async Task<ApiResponse<FamilyDto>> AuditingPublicAsync(FamilyPutDto parameter)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Put;
            request.Route = $"api/{ServiceName}/{parameter.Id}";
            request.Parameter = parameter;
            return await client.ExecuteAsync<FamilyDto>(request);
        }


        public async Task<ApiResponse<IEnumerable<FamilyDto>>> UploadPublicAsync(long creatorId,UploadFileDtoBase parameter)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Post;
            request.Route = $"api/{ServiceName}/User/{creatorId}";
            //request.FilePaths = parameter.Files;
            return await client.ExecuteAsync<IEnumerable<FamilyDto>>(request);
        }


        public async Task<ApiResponse<byte[]>> DownLoadFamily(long familyId)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/{ServiceName}/{familyId}";
            return await client.ExecuteAsync<byte[]>(request);
        }


       
    }
}