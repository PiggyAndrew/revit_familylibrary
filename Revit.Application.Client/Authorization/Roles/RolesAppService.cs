using Abp.Application.Services.Dto;
using Revit.ApiClient;
using Revit.Shared.Entity.Permissions;
using Revit.Shared.Entity.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;
using Revit.Shared.Entity.Authorization.Roles;

namespace Revit.Application
{
    public class RolesAppService : ProxyAppServiceBase, IRoleAppService
    {

        public RolesAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<RoleCreateDto> PostRole(RoleCreateDto role)
        {
            return await ApiClient.PostAsync<RoleCreateDto>(GetEndpoint(),role);
        }


        public async Task DeleteRole(EntityDto input)
        {
            await ApiClient.DeleteAsync(GetEndpoint(nameof(DeleteRole)), input);
        }


       
        public async Task<GetRoleForEditOutput> GetRole(long? id)
        {
            return await ApiClient.GetAsync<GetRoleForEditOutput>(GetEndpoint(id?.ToString()));
        }


        public async Task<List<PermissionDto>> GetRolePermissions(long id)
        {
            return await ApiClient.GetAsync<List<PermissionDto>>($"api/Roles/{id}/permissions");
        }


        public async Task<ListResultDto<RoleDto>> GetListAsync(RolePageRequestDto request)
        {
            return await ApiClient.GetAsync<ListResultDto<RoleDto>>(GetEndpoint(), request);
        }

    }
}