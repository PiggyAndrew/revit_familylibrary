using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Revit.Shared.Entity;

namespace Revit.Shared.Entity.Commons.Dto
{
    public class PagedAndFilteredInputDto : IPagedResultRequest
    {
        [Range(1, AppConsts.MaxPageSize)]
        public int MaxResultCount { get; set; } = AppConsts.DefaultPageSize;

        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        public string Filter { get; set; }

        public PagedAndFilteredInputDto()
        {
        }
    }
}