using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Revit.EntityFrameworkCore;
using Revit.WebAPI.Auth;
using System.Text;

namespace Revit.WebAPI.Extension
{
    public static class JWTExtension
    {
        internal static void AddRevitJWT(this WebApplicationBuilder builder)
        {
            var jwtBearer = builder.Configuration.GetSection(AppSettings.Autherization).GetSection(AppSettings.JwtBearer);
            //指定身份验证，加入jwt验证
            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(option =>
            {

                option.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,//是否验证Issuer
                    ValidIssuer = jwtBearer.GetValue<string>(AppSettings.Issuer),//Issuer

                    ValidateAudience = true,//是否验证Audience
                    ValidAudience = jwtBearer.GetValue<string>(AppSettings.Audience),//Audience

                    ValidateIssuerSigningKey = true,//是否验证SecurityKey
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtBearer.GetValue<string>(AppSettings.SecurityKey))),//拿到SecurityKey

                    ValidateLifetime = false,//是否验证失效时间
                    ClockSkew = TimeSpan.FromSeconds(5)//偏差秒数：防止客户端与服务器时间偏差
                };
            });
        }
    }
}
