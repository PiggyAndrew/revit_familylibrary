namespace Revit.Shared.Entity.Users
{
    public class UserRoleDto
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public string RoleDisplayName { get; set; }

        public bool IsAssigned { get; set; }

        public bool InheritedFromOrganizationUnit { get; set; }
    }
}