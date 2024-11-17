using Revit.Accounts.Dto;
using Revit.Shared.Entity.Accounts.DTO;
using Revit.Shared.Entity.Commons;

namespace Revit.Shared.Entity.Project
{
    public class ProjectResponseDto : DtoBase
    {

        public string ProjectName { get; set; }

        public AccountDto UserDto { get; set; }

        public int ProjectUserCount { get; set; }

        public double DocumentsSize { get; set; }

        public string BasePath { get; set; }


    }
}
