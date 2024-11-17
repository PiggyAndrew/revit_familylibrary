using Revit.Service.Commons;

namespace Revit.WebAPI.Extension
{
    public static class ServiceExtension
    {
        internal static void AddRevitServices(this WebApplicationBuilder builder)
        {
            var assemblies = AppDomain.CurrentDomain.GetReferanceAssemblies();
            foreach (var assembly in assemblies)
            {
                try
                {
                    List<Type> types = assembly.GetTypes()
                        .Where(t => t.BaseType == typeof(BaseService))
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
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
               
            }

        }
    }
}
