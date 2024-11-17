using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Commons;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Revit.Shared.Entity.Family
{
    public interface IFamilyAppService
    {
        Task<FamilyDto> AuditingPublicAsync(FamilyPutDto parameter);
        Task<byte[]> DownLoadFamily(long familyId);
        Task<PagedResultDto<FamilyDto>> GetPageListAsync(FamilyPageRequestDto parameter);
        Task<ListResultDto<FamilyDto>> GetUploadedFamilies(long userId);
        Task<ListResultDto<FamilyDto>> UploadPublicAsync(long creatorId, UploadFileDtoBase parameter);
    }
}