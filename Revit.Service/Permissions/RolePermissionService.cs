using AutoMapper;
using Revit.Repository;
using Revit.Service.Commons;
using Revit.Entity.Permissions;
using Revit.Entity.Roles;
using Revit.Entity.Commons;
using Revit.Shared.Entity.Accounts;
using Revit.Shared.Entity.Accounts.DTO;
using Revit.Shared.Entity.Permissions;


namespace Revit.Service.Permissions
{
    /// <summary>
    /// 角色权限关系
    /// </summary>
    public class RolePermissionService : BaseService, IRolePermissionService
    {
        private readonly IBaseRepository<R_Permission> _permissionsRepository;
        private readonly IBaseRepository<R_RolePermission> _rolePermissionRepository;
        private readonly IBaseRepository<R_Role> _roleRepository;

        private readonly IMapper _mapper;

        public RolePermissionService(IBaseRepository<R_Permission> permissionsRepository
            , IBaseRepository<R_RolePermission> rolePermissionRepository
            , IBaseRepository<R_Role> roleRepository, IMapper mapper) :base(mapper)
        {
            _mapper = mapper;
            _permissionsRepository = permissionsRepository;
            _rolePermissionRepository = rolePermissionRepository;
            _roleRepository = roleRepository;
        }

        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public List<AccountPermissionsDto> GetRolePermissions(string roleName)
        {
            //根据角色获取权限列表
            var permissions = (from p in _permissionsRepository.GetQueryable()
                               join rp in _rolePermissionRepository.GetQueryable() on p.Id equals rp.PermissionId
                               join r in _roleRepository.GetQueryable() on rp.RoleId equals r.Id
                               where r.NormalizedName == roleName && p.Status == PermissionStatus.Normal
                               select p
                     ).ToList();

            //对象映射转化
            var permissionsDtos = _mapper.Map<List<AccountPermissionsDto>>(permissions);

            return permissionsDtos;
        }

        /// <summary>
        /// 获取角色权限列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public List<PermissionDto> GetRolePermissions(long roleId)
        {
            var permissions = new List<PermissionDto>();
            var list = _rolePermissionRepository.GetList(x => x.RoleId == roleId);
            var mapper = MappingProfile.CreateMapper();
            foreach (var item in list)
            {
                var R_Permission = _permissionsRepository.Get(item.PermissionId);

                var permissionDto = mapper.Map<PermissionDto>(R_Permission);
                permissions.Add(permissionDto);
            }

            return permissions;
        }

        /// <summary>
        /// 保存角色的权限列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="permissionIds"></param>
        /// <param name="CreatorId"></param>
        /// <returns></returns>
        public bool SavePermissions(long roleId, List<long> permissionIds, long creatorId)
        {
            _rolePermissionRepository.Delete(x => x.RoleId == roleId);
            var list = new List<R_RolePermission>();
            foreach (var item in permissionIds)
            {
                var R_RolePermission = new R_RolePermission();
                R_RolePermission.RoleId = roleId;
                R_RolePermission.PermissionId = item;
                R_RolePermission.CreationTime = DateTime.Now;
                R_RolePermission.CreatorId = creatorId;
                list.Add(R_RolePermission);
            }

            return _rolePermissionRepository.AddRange(list) > 0;
        }
    }
}
