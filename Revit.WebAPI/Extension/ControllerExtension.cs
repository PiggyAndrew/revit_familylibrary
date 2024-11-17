using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Revit.Service.UnitOfWork;
using Revit.WebAPI.Auth;

namespace Revit.WebAPI.Extension
{
    public static class ControllerExtension
    {
        internal static void AddRevitController(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers(config =>
            {
                config.Filters.Add<UnitOfWorkFilterAttribute>();
                config.Filters.Add<R_AuthorizeAttribute>();
            }).AddNewtonsoftJson(option =>
            {
                //解析long类型为string类型的ID，放置精度丢失
                option.SerializerSettings.ContractResolver = new CustomContractResolver();

                option.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm";
            });
        }

    }
}
