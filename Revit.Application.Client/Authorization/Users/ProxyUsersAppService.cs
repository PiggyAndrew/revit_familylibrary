using Abp.Application.Services.Dto;
using Revit.ApiClient;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Users;
using System.Net.Http;
using System.Threading.Tasks;
using Revit.Shared.Entity.Authorization.Users;

namespace Revit.Authorization.Users
{
    public class ProxyUsersAppService : ProxyAppServiceBase, IUserAppService
    {

        public ProxyUsersAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<PagedResultDto<UserDto>> GetPageListAsync(UserPageRequestDto pageRequestDto)
        {
            return await ApiClient.GetAsync<PagedResultDto<UserDto>>(GetEndpoint(), pageRequestDto);
        }

        public async Task<GetUserForEditOutput> GetEditUser(NullableIdDto<long> nullableIdDto)
        {
            return await ApiClient.GetAsync<GetUserForEditOutput>(GetEndpoint("Edit"), nullableIdDto);
        }

        public async Task<UserDto> CreateOrUpdateUser(CreateOrUpdateUserInput input)
        {
           return await ApiClient.PostAsync<UserDto>(GetEndpoint(), input);
        }

        public async Task DeleteUser(EntityDto<long> input)
        {
            await ApiClient.DeleteAsync(GetEndpoint(), input);
        }

        public async Task UnlockUser(EntityDto<long> input)
        {
            await ApiClient.PostAsync(GetEndpoint(nameof(UnlockUser)), input);
        }

      
    }
}