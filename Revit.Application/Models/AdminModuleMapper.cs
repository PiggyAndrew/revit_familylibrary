using AppFramework.Admin.Models;
using AutoMapper;
using Revit.Application.Models.Permission;
using Revit.Application.Models.Users;
using Revit.Families;
using Revit.Shared.Entity.Categories;
using Revit.Shared.Entity.Family;
using Revit.Shared.Entity.Permissions;
using Revit.Shared.Entity.Users;
using CategoryListModel = Revit.Application.Models.Category.CategoryListModel;

namespace Revit.Application.Models
{
    public class AdminModuleMapper : Profile
    {
        public AdminModuleMapper()
        {

            CreateMap<CategoryCreateDto, CategoryDto>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id)).ReverseMap();
            CreateMap<CategoryListModel, CategoryDto>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id)).ReverseMap();
            CreateMap<CategoryCreateDto, CategoryForEditModel>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id)).ReverseMap();
            CreateMap<CategoryPutDto, CategoryForEditModel>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id)).ReverseMap();
            CreateMap<CategoryForEditModel, CategoryListModel>().ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id)).ReverseMap();


            CreateMap<FlatPermissionWithLevelDto, PermissionModel>().ReverseMap();

            //系统模块中实体映射关系 
            CreateMap<CategoryDto, CategoryListModel>().ReverseMap();
            CreateMap<FlatPermissionDto, PermissionModel>().ReverseMap();
            CreateMap<UserEditDto, UserEditModel>().ReverseMap();
            CreateMap<GetUserForEditOutput, UserForEditModel>().ForMember(x => x.User, opt => opt.MapFrom(x => x.User))
                .ReverseMap();


        }
    }
}
