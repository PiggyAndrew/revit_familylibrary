using Revit.ApiClient;
using Revit.Application.Client;
using Revit.Application;
using Revit.Authorization.Permissions;
using Revit.Authorization.Users;
using Prism.Ioc;
using Revit.Shared.Validations;
using Revit.Shared.Services.Datapager;
using Revit.Service.ApiServices;
using Revit.Entity;
using Revit.Service.IServices;
using Revit.Categories;
using Revit.Families;
using Revit.Authorization.Accounts;
using Revit.IServices;
using Revit.Shared.Entity.Authorization.Permissions;
using Revit.Shared.Entity.Authorization.Roles;
using Revit.Shared.Entity.Authorization.Users;
using Revit.Shared.Entity.Auths;
using Revit.Shared.Entity.Auths.Dto;
using Revit.Shared.Entity.Family;

namespace Revit.Shared
{
    public static class SharedModuleExtensions
    {
        public static void AddSharedServices(this IContainerRegistry registry)
        {
            registry.RegisterSingleton<PrismBootstrapperBase>();

            registry.RegisterSingleton<IGlobalValidator, GlobalValidator>();
            registry.RegisterSingleton<AbpApiClient>();
            registry.RegisterSingleton<AbpAuthenticateModel>();
            registry.RegisterSingleton<IAccessTokenManager, AccessTokenManager>();

            registry.RegisterInstance(new MyHttpClient(Global.HOST));
            registry.Register<IDataPagerService, DataPagerService>();
            registry.Register<IPermissionAppService, PermissionAppService>();
            registry.Register<IAuthsAppService, AuthsAppService>();
            //registry.Register<IAccountService, AccountService>();

            //旧service


            registry.Register<IAuditLogAppService, AuditLogAppService>();
            registry.Register<IPermissionAppService, PermissionAppService>();
            registry.Register<IUserAppService, ProxyUsersAppService>();
            registry.Register<IRoleAppService, RolesAppService>();
            registry.Register<ICategoryAppService, CategoryAppService>();
            registry.Register<IFamilyAppService, FamilyAppService>();
        }
    }
}
