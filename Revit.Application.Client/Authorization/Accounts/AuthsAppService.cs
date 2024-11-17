using System.Threading.Tasks;
using Revit.ApiClient;
using Revit.IServices;

namespace Revit.Authorization.Accounts
{
    public class AuthsAppService : ProxyAppServiceBase, IAuthsAppService
    {
        private readonly IAccessTokenManager _accessTokenManager;


        public AuthsAppService(AbpApiClient apiClient, IAccessTokenManager accessTokenManager) : base(apiClient)
        {
            _accessTokenManager = accessTokenManager;
        }

        public async Task LoginAsync()
        {
            var result = await _accessTokenManager.LoginAsync();
        }
    }
}