using Abp.Application.Services.Dto;
using Revit.Entity.Commons;
using Revit.Entity.Family;
using Revit.Shared.Entity.Family;

namespace Revit.Service.Families
{
    public interface IFamilyService
    {
        Task<ListResultDto<FamilyDto>> GetFamiliesByUser(long userId);
        Task<PagedResultDto<FamilyDto>> GetListAsync(FamilyPageRequestDto parameters);
        Task<ListResultDto<FamilyDto>> UploadFiles(long creatorId, FamilyUploadDto filesDto);
        Task<byte[]> DownloadFamily(long familyId);
        Task<FamilyDto> AuditingFamily(long familyId,FamilyPutDto familyPutDto);
    }
}