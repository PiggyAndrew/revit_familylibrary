using Revit.Accounts.Dto;
using Revit.Service.ApiServices;
using Revit.Service.IServices;
using Revit.Shared.Entity.Commons;
using System.Net.Http;
using System.Threading.Tasks;
using Abp.Web.Models;

namespace Revit.Service.Services
{
    public class AccountService : BaseService<LoginedUserDto>, IAccountService
    {
        public AccountService(MyHttpClient client) : base(client)
        {
            this.ServiceName = "Accounts";
        }

        public async Task<AjaxResponse<LoginedUserDto>> GetLoginedUser(string token)
        {
            BaseRequest request = new BaseRequest();
            request.Method = HttpMethod.Get;
            request.Route = $"api/{ServiceName}";
            request.Token= token;
            request.ContentType= ContentType.Json;
            return await client.ExecuteAsync<LoginedUserDto>(request);
        }


    }
}
