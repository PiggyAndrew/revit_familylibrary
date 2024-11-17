using Microsoft.OpenApi.Models;
using Revit.WebAPI.Auth;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;

namespace Revit.WebAPI.Extension
{
    public static class SwaggerGenExtension
    {

        internal static void AddRevitSwaggerGen(this WebApplicationBuilder builder)
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo() { Title = "API", Version = "v1" });
                //开启加权小锁
                option.OperationFilter<AddResponseHeadersFilter>();
                option.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                //在Header中添加Token传递到后台
                option.OperationFilter<SecurityRequirementsOperationFilter>();
                //添加描述
                option.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}(注意两者之间有一个空格)",
                    Name = AppSettings.Autherization,//jwt默认的参数名称,
                    In = ParameterLocation.Header,//jwt默认存放Autorization信息的位置（header中）
                    Type = SecuritySchemeType.ApiKey
                });

                //为 Swagger 设置xml文档注释路径
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 添加控制器层注释，true表示显示控制器注释
                option.IncludeXmlComments(xmlPath, true);
            });
        }
    }
}
