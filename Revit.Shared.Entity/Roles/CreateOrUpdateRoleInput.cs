using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Revit.Shared.Entity.Roles
{
    public class CreateOrUpdateRoleInput
    {
        [Required]
        public RoleCreateDto Role { get; set; }

        [Required]
        public List<string> GrantedPermissionNames { get; set; }
    }
}