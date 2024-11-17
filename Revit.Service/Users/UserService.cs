using Abp.Application.Services.Dto;
using AutoMapper;

using Revit.Entity.Users;
using Revit.Service.Commons;
using Revit.Repository;
using Revit.Entity.Roles;
using Revit.Shared.Entity.Users;
using Revit.Shared.Entity.Roles;
using Abp.Linq.Extensions;


namespace Revit.Service.Users
{
    /// <summary>
    /// 用户
    /// </summary>
    public class UserService : BaseService, IUserService
    {
        private readonly IBaseRepository<R_User> _userRepository;
        private readonly IBaseRepository<R_Role> _roleRepository;
        private readonly IBaseRepository<R_UserRole> _userRoleRepository;

        private readonly IMapper _mapper;

        public UserService(IBaseRepository<R_User> userRepository
            , IBaseRepository<R_Role> roleRepository
            , IBaseRepository<R_UserRole> userRoleRepository, IMapper mapper) : base(mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleRepository = userRoleRepository;
        }

        /// <summary>
        /// 搜索用户
        /// </summary>
        /// <param name="userPageRequestDto"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<UserDto>> GetListAsync(UserPageRequestDto userPageRequestDto)
        {
            //过滤
            var query = _userRepository.GetQueryable().Where(x =>
                x.UserName.Contains(userPageRequestDto.UserName) ||
                string.IsNullOrWhiteSpace(userPageRequestDto.UserName));


            var count = query.Count();
            query = query.PageBy(userPageRequestDto);
            var userDtos = _mapper.Map<List<UserDto>>(query);
            foreach (var userDto in userDtos)
            {
                //创建者
                var creator = _userRepository.Get(userDto.CreatorId);
                userDto.Creator = _mapper.Map<UserDto>(creator);

                //获取用户关联的角色列表
                var roleList = (from r in _roleRepository.GetQueryable()
                                join ur in _userRoleRepository.GetQueryable() on r.Id equals ur.RoleId
                                where ur.UserId == userDto.Id
                                select r).ToList();
                userDto.Roles = _mapper.Map<List<RoleDto>>(roleList);
            }

            return new PagedResultDto<UserDto>(count, userDtos);
        }

        public async Task<GetUserForEditOutput> GetUserForEdit(NullableIdDto<long> idDto)
        {
            var user = await _userRepository.GetAsync(idDto.Id);

            var roleList = (from r in _roleRepository.GetQueryable()
                            join ur in _userRoleRepository.GetQueryable() on r.Id equals ur.RoleId
                            where ur.UserId == user.Id
                            select r).ToList();
            var allRole = _mapper.Map<List<UserRoleDto>>(_roleRepository.GetAll());
            foreach (var role in allRole)
            {

                if (roleList.Any(userRole=> userRole.Id==role.RoleId))
                {
                    role.IsAssigned = true;
                }
            }
            return new GetUserForEditOutput
            {
                User = _mapper.Map<UserEditDto>(user),
                Roles = allRole.ToArray()
            };
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public List<string> GetRoles(string userName)
        {
            var roles = (from r in _roleRepository.GetQueryable()
                         join ur in _userRoleRepository.GetQueryable() on r.Id equals ur.RoleId
                         join u in _userRepository.GetQueryable() on ur.UserId equals u.Id
                         where u.UserName == userName
                         select r.Name).ToList();
            return roles;
        }

        /// <summary>
        /// 获取所有用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserAllDto> GetAll()
        {
            var list = _userRepository.GetAll();

            return _mapper.Map<List<UserAllDto>>(list);
        }
    }
}
