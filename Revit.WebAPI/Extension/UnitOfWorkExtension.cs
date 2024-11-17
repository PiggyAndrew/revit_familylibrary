using Revit.Service.UnitOfWork;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Extension
{
    public static class UnitOfWorkExtension
    {
        internal static void AddRevitUnitOfWork(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IUnitOfWork, Service.UnitOfWork.UnitOfWork>();
            builder.Services.AddScoped<UnitOfWorkAttribute>();
        }
    }
}
