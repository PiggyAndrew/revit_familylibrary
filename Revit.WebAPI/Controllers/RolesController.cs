using Abp.Application.Services.Dto;
using Abp.Web.Models;
using AutoMapper;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Roles;
using Revit.Entity.Users;
using Revit.Service.Permissions;
using Revit.Service.Roles;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Roles;
using Revit.WebAPI.UnitOfWork;

namespace Electric.API.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    //[R_Authorize]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IRolePermissionService _rolePermissionRepositiory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<R_User> _userManager;
        private readonly RoleManager<R_Role> _roleManager;
        private readonly IMapper _mapper;

        public RolesController(IRoleService roleService, IRolePermissionService rolePermissionRepositiory, IHttpContextAccessor httpContextAccessor,
            UserManager<R_User> userManager, IMapper mapper, RoleManager<R_Role> roleManager)
        {
            _roleService = roleService;
            _rolePermissionRepositiory = rolePermissionRepositiory;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _mapper = mapper;
            _roleManager = roleManager;
        }


        [HttpGet("{id?}")]
        public async Task<IActionResult> GetRoleForEdit(long? id)
        {
            RoleCreateDto roleEditDto = null;
            if (id.HasValue) 
            {
                roleEditDto =_mapper.Map<RoleCreateDto>(_roleService.GetRole(id.Value));
            }
            else
            {
                roleEditDto = new RoleCreateDto() { };
            }

            return Ok(new AjaxResponse(new GetRoleForEditOutput
            {
                Role = roleEditDto
            }));
        }

        /// <summary>
        /// 角色搜索
        /// </summary>
        /// <param name="rolePageRequestDto"></param>
        /// <returns></returns>
        [HttpGet()]
        [UnitOfWork(IsTransactional = false)]
        public async Task<ActionResult> Get([FromQuery] RolePageRequestDto rolePageRequestDto)
        {
            //角色搜索
            var result =await _roleService.GetListAsync(rolePageRequestDto);

            return Ok(new AjaxResponse(result));
        }

        /// <summary>
        /// 保存角色的权限列表
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <param name="rolePermissionDto">以,分割权限Id</param>
        /// <returns></returns>
        [HttpPut("{id}/permissions")]
        public async Task<IActionResult> SavePermissions(long id, [FromBody] RolePermissionDto rolePermissionDto)
        {
            //获取个人信息
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);

            //保存权限
            _rolePermissionRepositiory.SavePermissions(id, rolePermissionDto.PermissionIds, user.Id);

            return Ok();
        }

        /// <summary>
        /// 获取角色的权限列表
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}/permissions")]
        public IActionResult GetPermissions(long id)
        {
            //获取角色的权限列表
            var rolePermissionDtos = _rolePermissionRepositiory.GetRolePermissions(id);

            return Ok(new AjaxResponse(rolePermissionDtos));
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="roleCreateDto"></param>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleCreateDto roleCreateDto)
        {
            var R_Role = _mapper.Map<R_Role>(roleCreateDto);

            var result = await _roleManager.CreateAsync(R_Role);
            if (result.Succeeded)
            {
                return Ok(new AjaxResponse(roleCreateDto) );
            }
            else
            {
                var responseResult = new AjaxResponse();
                return BadRequest(responseResult);
            }
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleUpdateDto"></param>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, [FromBody] RoleUpdateDto roleUpdateDto)
        {
            //获取角色
            var R_Role = await _roleManager.FindByIdAsync(id.ToString());
            if (R_Role == null)
            {
                var responseResult = new AjaxResponse();
                return BadRequest(responseResult);
            }

            //更新字段
            _mapper.Map(roleUpdateDto, R_Role);
            R_Role.LastModificationTime = DateTime.Now;
            var result = await _roleManager.UpdateAsync(R_Role);

            if (result.Succeeded)
            {
                return NoContent();
            }
            else
            {
                var notFound = new AjaxResponse();
                return BadRequest(notFound);
            }
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var responseResult = new AjaxResponse();

            var R_Role = await _roleManager.FindByIdAsync(id.ToString());
            //初始化数据，不可删除
            if (id == 1)
            {
                return BadRequest(responseResult);
            }
            else if (R_Role == null)
            {
                return BadRequest(responseResult);
            }

            //删除角色
            await _roleManager.DeleteAsync(R_Role);
            return NoContent();
        }


       
    }
}
