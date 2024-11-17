using Abp.Application.Services.Dto;
using Revit.ApiClient;
using Revit.Demo.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Demo
{
    public class AbpDemoAppService : ProxyAppServiceBase, IAbpDemoAppService
    {
        public AbpDemoAppService(AbpApiClient apiClient) : base(apiClient)
        { }

        public async Task<PagedResultDto<AbpDemoDto>> GetAll(GetAllAbpDemoInput input)
        {
            return await ApiClient.GetAsync<PagedResultDto<AbpDemoDto>>(GetEndpoint(nameof(GetAll)), input);
        }
    }
}
