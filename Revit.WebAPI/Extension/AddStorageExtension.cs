using AutoMapper;
using FileService.Infrastructure.Services;
using Revit.Service.Commons;
using Revit.Service.Families;
using Revit.WebAPI.Auth;

namespace Revit.WebAPI.Extension
{
    public static class AddStorageExtension
    {
        internal static void AddStorage(this WebApplicationBuilder builder)
        {
            builder.Services//.AddOptions() //asp.net core项目中AddOptions()不写也行，因为框架一定自动执行了
     .Configure<LocalStorageOptions>(builder.Configuration.GetSection(AppSettings.SaveStorageBase));


            var assemblies = AppDomain.CurrentDomain.GetReferanceAssemblies();
            foreach (var assembly in assemblies)
            {
                List<Type> types = assembly.GetTypes()
                    .Where(t => t.GetInterfaces().Any(i=>i == typeof(IStorageClient)) )
                    .ToList();
                types.ForEach(type =>
                {
                    //获取该类所继承的所有接口
                    Type[] interfaces = type.GetInterfaces();
                    interfaces.ToList().ForEach(interfaceObject =>
                    {
                        builder.Services.AddTransient(interfaceObject, type);
                    });
                });
            }
        }
    }
}
