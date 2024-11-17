using Revit.Shared.Entity.Commons;
using System.Threading.Tasks;
using Abp.Web.Models;
using Revit.Accounts.Dto;

namespace Revit.Service.IServices
{
    public interface IAccountService
    {
        Task<AjaxResponse<LoginedUserDto>> GetLoginedUser(string content);
    }
}