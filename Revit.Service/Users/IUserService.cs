
using Abp.Application.Services.Dto;
using Revit.Entity.Commons;

using Revit.Shared.Entity.Users;
namespace Revit.Service.Users
{
    public interface IUserService
    {
        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        List<UserAllDto> GetAll();

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        List<string> GetRoles(string userName);

        /// <summary>
        /// 搜索用户
        /// </summary>
        /// <param name="userPageRequestDto"></param>
        /// <returns></returns>
        Task<PagedResultDto<UserDto>> GetListAsync(UserPageRequestDto userPageRequestDto);

        Task<GetUserForEditOutput> GetUserForEdit(NullableIdDto<long> idDto);
    }
}