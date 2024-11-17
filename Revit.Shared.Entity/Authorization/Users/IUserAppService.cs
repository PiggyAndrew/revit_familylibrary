using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Revit.Shared.Entity.Users;

namespace Revit.Shared.Entity.Authorization.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<PagedResultDto<UserDto>> GetPageListAsync(UserPageRequestDto userPageRequestDto);

        Task<UserDto> CreateOrUpdateUser(CreateOrUpdateUserInput input);

        Task DeleteUser(EntityDto<long> input);

        Task UnlockUser(EntityDto<long> input);

        Task<GetUserForEditOutput> GetEditUser(NullableIdDto<long> nullableIdDto);
    }
}