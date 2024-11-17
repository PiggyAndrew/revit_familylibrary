using AutoMapper;
using Revit.Entity.Commons;

namespace Revit.WebAPI.Extension
{
    public static class AutoMapperExtension
    {
        internal static void AddRevitAutoMapper(this WebApplicationBuilder builder)
        {
            //AutoMapper依赖注入
            AutoMapper.IConfigurationProvider config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            builder.Services.AddSingleton(config);
            builder.Services.AddScoped<IMapper, Mapper>();
        }
    }
}
