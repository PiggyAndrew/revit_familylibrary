using AutoMapper;
using Revit.WebAPI.Auth;

namespace Revit.WebAPI.Extension
{
    public static class CorsOriginsExtension
    {
        internal static string AddRevitCorsOrigins(this WebApplicationBuilder builder)
        {
            //跨域配置
            var allowSpecificOrigins = "allowSpecificOrigins";
            var corsOrigins = builder.Configuration.GetSection(AppSettings.CorsOrigins).Value;
            builder.Services.AddCors(m => m.AddPolicy(allowSpecificOrigins,
            a => a.SetIsOriginAllowed(_ => true).AllowAnyMethod().AllowAnyHeader().AllowCredentials()));
            //允许任何地址访问
            //a => a.WithOrigins(corsOrigins.Split(',', StringSplitOptions.RemoveEmptyEntries)).AllowAnyMethod().AllowAnyHeader().AllowCredentials()));
            return allowSpecificOrigins;
        }
    }
}
