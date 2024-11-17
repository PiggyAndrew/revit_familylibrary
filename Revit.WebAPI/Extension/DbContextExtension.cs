using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using Revit.WebAPI.Auth;
using System.Reflection;

namespace Revit.WebAPI.Extension
{
    public static class DbContextExtension
    {

        internal static void AddRevitDbContext(this WebApplicationBuilder builder)
        {

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                //启用的数据库类型
                var provider = builder.Configuration.GetValue<string>(AppSettings.DataProvider);
                switch (provider)
                {
                    case "MsSql":
                        var msSqlConnection = builder.Configuration.GetConnectionString(AppSettings.MsSqlConnection) ?? throw new InvalidOperationException("MsSqlConnection在appsettings.json未发现");
                        options.UseSqlServer(msSqlConnection);
                        break;
                    case "MySql":
                        var mySqlConnection = builder.Configuration.GetConnectionString(AppSettings.MySqlConnection) ?? throw new InvalidOperationException("MySqlConnection在appsettings.json未发现");
                        //MySql需要传入版本，ServerVersion.AutoDetect根据连接字符串自动获取
                        options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection));
                        break;
                    case "Sqlite":
                        var sqliteConnection = builder.Configuration.GetConnectionString("SqliteConnection") ?? throw new InvalidOperationException("MySqlConnection在appsettings.json未发现");
                        //MySql需要传入版本，ServerVersion.AutoDetect根据连接字符串自动获取
                        options.UseSqlite(sqliteConnection, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
                        break;
                }
            },ServiceLifetime.Scoped);

            builder.Services.AddIdentity<R_User, R_Role>()
           .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
        }
    }
}
