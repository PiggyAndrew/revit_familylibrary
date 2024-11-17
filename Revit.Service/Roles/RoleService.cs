using AutoMapper;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
using Abp.Application.Services.Dto;
using Revit.Service.Commons;
using Revit.Repository;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Entity.Commons;
using Revit.Entity.Permissions;
using Revit.Service.Permissions;
using Revit.Shared.Entity.Roles;
using Revit.Shared.Entity.Users;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Revit.Service.Roles
{
    /// <summary>
    /// 角色
    /// </summary>
    public class RoleService : BaseService, IRoleService
    {
        private readonly IBaseRepository<R_Role> _roleRepository;
        private readonly IBaseRepository<R_User> _userRepository;
        private readonly IBaseRepository<R_RolePermission> _rolePermissionRepository;
        private readonly IMapper _mapper;

        public RoleService(IBaseRepository<R_Role> roleRepository
            , IBaseRepository<R_User> userRepository
            , IBaseRepository<R_RolePermission> rolePermissionRepository
            , IMapper mapper):base(mapper)
        {
            _mapper = mapper;
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _rolePermissionRepository = rolePermissionRepository;
        }

        /// <summary>
        /// 搜索角色
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        public async Task<ListResultDto<RoleDto>> GetListAsync(RolePageRequestDto rolePageRequestDto)
        {
            var query = _roleRepository.GetQueryable();
            if (!string.IsNullOrEmpty(rolePageRequestDto.Name))
            {
                query = query.Where(x => x.Name.Equals(rolePageRequestDto.Name));
            }
            var roleDtos = _mapper.Map<List<RoleDto>>(query);
            foreach (var roleDto in roleDtos)
            {
                //创建者
                var creator = _userRepository.Get(roleDto.CreatorId);
                roleDto.Creator = _mapper.Map<UserDto>(creator);
            }
            return new ListResultDto<RoleDto>(roleDtos);
        }

       

        public async Task<RoleDto> GetRole(long id)
        {
            var role=_roleRepository.Get(id);
            if (role!=null)
            {
                var roleDto = _mapper.Map<RoleDto>(role);
                return roleDto;
            }
            throw new ArgumentNullException("This role id is invalid");
        }
    }
}
