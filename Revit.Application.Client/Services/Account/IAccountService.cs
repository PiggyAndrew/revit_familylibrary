using Revit.ApiClient.Models;
//using Revit.Admin.Models;
using System.Threading.Tasks;

namespace Revit.Admin.Services
{
    public interface IAccountService
    {
        AbpAuthenticateModel AuthenticateModel { get; set; }

        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }

        Task LoginUserAsync();

        //Task LoginCurrentUserAsync(UserListModel user);

        Task LogoutAsync();
    }
}