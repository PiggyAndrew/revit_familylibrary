using Revit.ApiClient;
using Revit.Shared;
using System;

namespace Revit.Admin.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IApplicationContext appContext;

        public PermissionService(IApplicationContext appContext)
        {
            this.appContext = appContext;
        }

        public bool HasPermission(string key)
        {
            if (appContext.Configuration.Auth.GrantedPermissions.TryGetValue(key, out var permissionValue))
                return string.Equals(permissionValue, "true", StringComparison.OrdinalIgnoreCase);

            return false;
        }
    }
}