using Abp.Application.Services.Dto;
using Revit;
using Revit.ApiClient;
using Revit.Authorization.Users;
using Revit.Authorization.Users.Dto; 
using System.Threading.Tasks;

namespace Revit.Authorization.Users
{
    public class UserLinkAppService : ProxyAppServiceBase, IUserLinkAppService
    {
        public UserLinkAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input)
        {
            return await ApiClient.GetAsync<PagedResultDto<LinkedUserDto>>(GetEndpoint(nameof(GetLinkedUsers)), input);
        }

        public async Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers()
        {
            return await ApiClient.GetAsync<ListResultDto<LinkedUserDto>>(GetEndpoint(nameof(GetRecentlyUsedLinkedUsers)));
        }

        public async Task LinkToUser(LinkToUserInput linkToUserInput)
        {
            await ApiClient.PostAsync(GetEndpoint(nameof(LinkToUser)), linkToUserInput);
        }

        public async Task UnlinkUser(UnlinkUserInput input)
        {
            await ApiClient.PostAsync(GetEndpoint(nameof(UnlinkUser)), input);
        }
    }
}
