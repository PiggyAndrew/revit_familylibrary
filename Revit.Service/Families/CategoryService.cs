using Abp.Application.Services.Dto;
using AutoMapper;
using Revit.Entity.Family;
using Revit.Repository;
using Revit.Service.Commons;
using Revit.Shared.Entity.Categories;
using Revit.Shared.Entity.Family;
using Snowflake.Core;

namespace Revit.Service.Families
{
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IBaseRepository<R_Category> _categoriesRepository;
        private readonly IStorageClient localStorage;
        private readonly IdWorker idWorker;

        public CategoryService(IBaseRepository<R_Category> categoriesRepository, IMapper mapper, IdWorker idWorker) : base(mapper)
        {
            this._categoriesRepository = categoriesRepository;
            this.idWorker = idWorker;
        }

        public async Task<CategoryDto> AddCategory(CategoryCreateDto createMessages)
        {
            var rCategory = _mapper.Map<R_Category>(createMessages);
            rCategory.Id = this.idWorker.NextId();
            _categoriesRepository.Add(rCategory);
            var result = _mapper.Map<CategoryDto>(rCategory);
            return result;
        }

        public async Task<ListResultDto<CategoryDto>> GetCategories()
        {
            var results = _categoriesRepository.GetList(x => true).ToList();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(results);
            return new ListResultDto<CategoryDto>(categoryDtos);
        }


        public async Task<int> DeleteCategory(long categoryId)
        {
            var item = _categoriesRepository.Get(categoryId);
            if (item == null) throw new ArgumentNullException("This categoryId is represent nothing");
            var count = _categoriesRepository.Delete(item);
            return count;
        }

        public Task<int> UpdateCategory(CategoryPutDto categoryPutDto)
        {
            var category = _categoriesRepository.Get(categoryPutDto.Id);
            category.Name = categoryPutDto.Name;
            category.CategoryType = categoryPutDto.CategoryType;

           var count=  _categoriesRepository.Update(category);

           return Task.FromResult(count);
        }
    }
}
