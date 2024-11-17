using Abp.Application.Services.Dto;
using Revit;
using Revit.ApiClient;
using Revit.Authorization.Permissions;
using Revit.Shared.Entity.Permissions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Revit.Shared.Entity.Authorization.Permissions;

namespace Revit.Authorization.Permissions
{
    public class PermissionAppService : ProxyAppServiceBase, IPermissionAppService
    {
        private readonly string baseUrl = "api/permissions";


        public PermissionAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }


        public async Task<List<PermissionDto>> GetAllPermissions()
        {
            return await ApiClient.GetAsync<List<PermissionDto>>(baseUrl + "/all");
        }
    }
}
