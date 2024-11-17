using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//数据库上下文注入
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    //启用的数据库类型
    var provider = builder.Configuration.GetValue<string>("DataProvider");
    switch (provider)
    {
        case "MsSql":
            var msSqlConnection = builder.Configuration.GetConnectionString("MsSqlConnection") 
            ?? throw new InvalidOperationException("MsSqlConnection在appsettings.json未发现");
            options.UseSqlServer(msSqlConnection, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            break;
        case "MySql":
            var mySqlConnection = builder.Configuration.GetConnectionString("MySqlConnection") ?? throw new InvalidOperationException("MySqlConnection在appsettings.json未发现");
            //MySql需要传入版本，ServerVersion.AutoDetect根据连接字符串自动获取
            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection), b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            break;
        case "Sqlite":
            var sqliteConnection = builder.Configuration.GetConnectionString("SqliteConnection") ?? throw new InvalidOperationException("MySqlConnection在appsettings.json未发现");
            //MySql需要传入版本，ServerVersion.AutoDetect根据连接字符串自动获取
            options.UseSqlite(sqliteConnection, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            break;
    }
});


//Identity注入，添加数据库上下文
builder.Services.AddIdentity<R_User, R_Role>()
            .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

var app = builder.Build();
app.Run();