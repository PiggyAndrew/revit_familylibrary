using Abp.Application.Services.Dto;
using Revit.Shared.Entity;

namespace Revit.Shared.Entity.Commons.Dto
{
    public class PagedAndSortedInputDto : PagedInputDto, ISortedResultRequest
    {
        public string Sorting { get; set; } = "";

        public PagedAndSortedInputDto()
        {
            MaxResultCount = AppConsts.DefaultPageSize;
        }
    }
}