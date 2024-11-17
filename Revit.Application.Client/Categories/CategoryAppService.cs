using Abp.Application.Services.Dto;
using Abp.PlugIns;
using Revit.ApiClient;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Revit.Shared.Entity.Family;
using System.Linq;
using Revit.Families;
using Revit.Shared.Entity.Categories;

namespace Revit.Categories
{
    public class CategoryAppService : ProxyAppServiceBase, ICategoryAppService
    {
        public CategoryAppService(AbpApiClient apiClient) : base(apiClient)
        {
        }

        public async Task<ListResultDto<CategoryDto>> GetListAsync()
        {
            return await ApiClient.GetAsync<ListResultDto<CategoryDto>>(GetEndpoint());
        }

        public async Task<CategoryDto> AddCategory(CategoryCreateDto categoryCreateDto)
        {
            return await ApiClient.PostAsync<CategoryDto>(GetEndpoint(), categoryCreateDto);
        }

        public async Task<int> UpdateCategory(CategoryPutDto categoryCreateDto)
        {
            return await ApiClient.PutAsync<int>(GetEndpoint(), categoryCreateDto);
        }

        public async Task<int> DeleteCategory(long categoryId)
        {
            return await ApiClient.DeleteAsync<int>(GetEndpoint($"{categoryId}"), new EntityDto<long>(categoryId));
        }
    }
}
