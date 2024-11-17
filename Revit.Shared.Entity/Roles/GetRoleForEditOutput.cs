using System.Collections.Generic;

namespace Revit.Shared.Entity.Roles
{
    public class GetRoleForEditOutput
    {
        public RoleCreateDto Role { get; set; }

        //public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}