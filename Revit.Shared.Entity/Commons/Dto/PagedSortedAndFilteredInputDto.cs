namespace Revit.Shared.Entity.Commons.Dto
{
    public class PagedSortedAndFilteredInputDto : PagedAndSortedInputDto
    {
        public string Filter { get; set; } = "";

        public PagedSortedAndFilteredInputDto()
        {
        }
    }
}