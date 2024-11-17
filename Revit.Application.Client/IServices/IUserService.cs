using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Web.Models;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Users;

namespace Revit.IServices
{
    public interface IUserService
    {
        Task<AjaxResponse<IPagedResult<UserDto>>> GetUsers(UserPageRequestDto pageRequestDto);
    }
}