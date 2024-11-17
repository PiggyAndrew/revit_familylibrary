using AutoMapper;
using Revit.Shared.Entity.Roles;
using Revit.Shared.Entity.Users;

namespace Revit.Shared.Models
{
    public class SharedModuleMapper : Profile
    {
        public SharedModuleMapper()
        {
            CreateMap<RoleCreateDto, RoleCreateDto>().ReverseMap();
            CreateMap<UserDto, UserEditDto>().ReverseMap();
        }
    }
}