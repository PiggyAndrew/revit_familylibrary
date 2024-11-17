using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Categories;
using Revit.Shared.Entity.Family;

namespace Revit.Service.Families
{
    public interface ICategoryService
    {
        Task<CategoryDto> AddCategory( CategoryCreateDto createMessages);
        Task<ListResultDto<CategoryDto>> GetCategories();
        Task<int> DeleteCategory(long categoryId);
        Task<int> UpdateCategory(CategoryPutDto categoryPutDto);
    }
}