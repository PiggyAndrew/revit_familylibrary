using Revit.ApiClient; 
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Revit.Authorization.Users.Dto;

namespace Revit.Authorization.Users
{
    public class UserLoginAppService : ProxyAppServiceBase, IUserLoginAppService
    {
        public UserLoginAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<PagedResultDto<UserLoginAttemptDto>> GetUserLoginAttempts(GetLoginAttemptsInput input)
        {
            return await ApiClient.GetAsync<PagedResultDto<UserLoginAttemptDto>>(GetEndpoint(nameof(GetUserLoginAttempts)), input);
        }
    }
}
