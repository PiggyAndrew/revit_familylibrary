using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Categories;
using Revit.Shared.Entity.Family;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revit.Categories
{
    public interface ICategoryAppService
    {
        Task<CategoryDto> AddCategory(CategoryCreateDto categoryCreateDto);
        Task<int> DeleteCategory(long categoryId);
        Task<ListResultDto<CategoryDto>> GetListAsync();
        Task<int> UpdateCategory(CategoryPutDto categoryCreateDto);
    }
}