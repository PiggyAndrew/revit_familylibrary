using Autofac;
using Autofac.Extensions.DependencyInjection;
using Revit.WebAPI.Extension;

var builder = WebApplication.CreateBuilder(args);

//配置host与容器
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacModuleRegister());
});

//builder.Services.AddRateLimiter(config => config.AddFixedWindowLimiter("fixed", option =>
//{
//    option.PermitLimit = 100;
//    option.Window = TimeSpan.FromSeconds(10);
//    option.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
//    option.QueueLimit = 10;

//}));

//builder.Logging.AddConsole().AddEventLog();


builder.AddRevitController();

builder.AddRevitSwaggerGen();

builder.AddRevitDbContext();


//Identity注入，添加数据库上下文
builder.AddRevitServices();


builder.AddRevitAutoMapper();
//新增存储基础地址
builder.AddStorage();
//添加ID生成器
builder.AddIdWorker();
//swagger

builder.AddRevitUnitOfWork();

builder.ConfigFile();

builder.AddRevitJWT();


var origins = builder.AddRevitCorsOrigins();

var app = builder.Build();

app.UseCors(origins);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
