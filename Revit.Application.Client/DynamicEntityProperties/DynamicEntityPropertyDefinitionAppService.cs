using Revit.ApiClient;
using Revit.DynamicEntityProperties;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revit.Application
{
    public class DynamicEntityPropertyDefinitionAppService : ProxyAppServiceBase, IDynamicEntityPropertyDefinitionAppService
    {
        public DynamicEntityPropertyDefinitionAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<List<string>> GetAllAllowedInputTypeNames()
        {
            return await ApiClient.GetAsync<List<string>>(GetEndpoint(nameof(GetAllAllowedInputTypeNames)));
        }

        public async Task<List<string>> GetAllEntities()
        {
            return await ApiClient.GetAsync<List<string>>(GetEndpoint(nameof(GetAllEntities)));
        } 
    }
}