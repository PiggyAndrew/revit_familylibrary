using Abp.Application.Services.Dto;
using Revit.ApiClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Family;
using System.Linq;

namespace Revit.Families
{
    public class FamilyAppService : ProxyAppServiceBase, IFamilyAppService
    {
        public FamilyAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<PagedResultDto<FamilyDto>> GetPageListAsync(FamilyPageRequestDto parameter)
        {
            return await ApiClient.GetAsync<PagedResultDto<FamilyDto>>(GetEndpoint(), parameter);
        }

        public async Task<ListResultDto<FamilyDto>> GetUploadedFamilies(long userId)
        {
            return await ApiClient.GetAsync<ListResultDto<FamilyDto>>(GetEndpoint($"User/{userId}"), new EntityDto<long>(userId));
        }

        public async Task<FamilyDto> AuditingPublicAsync(FamilyPutDto parameter)
        {
            return await ApiClient.PutAsync<FamilyDto>(GetEndpoint($"{parameter.Id}"), parameter);
        }

        public async Task<ListResultDto<FamilyDto>> UploadPublicAsync(long creatorId, UploadFileDtoBase parameter)
        {
            return await ApiClient.PostMultipartAsync<ListResultDto<FamilyDto>>(GetEndpoint($"User/{creatorId}"), (x) => {
                x.AddFile("file", parameter.FilesPath.FirstOrDefault());
                x.AddFile("file", parameter.FilesPath.LastOrDefault());
            });
        }


        public async Task<byte[]> DownLoadFamily(long familyId)
        {
            return await ApiClient.GetAsync<byte[]>(GetEndpoint($"{familyId}"));
        }
    }
}
