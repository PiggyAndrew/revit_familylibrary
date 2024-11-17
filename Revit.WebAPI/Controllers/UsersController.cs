using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.VisualBasic;
using Revit.Entity.Users;
using Revit.Service.UnitOfWork;
using Revit.Service.Users;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Users;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;
using System.Diagnostics;
using Abp.Application.Services.Dto;
using Abp.Web.Models;

namespace Revit.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<R_User> _userManager;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UsersController(IUserService userRepository
            , IHttpContextAccessor httpContextAccessor
            , UserManager<R_User> userManager
            , IMapper mapper
            , IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 获取用户名称
        /// </summary>
        /// <param name="userPageRequestDto"></param>
        /// <returns></returns>
        [HttpGet]
        [UnitOfWork(IsTransactional = false)]
        public async Task<ActionResult<AjaxResponse<PagedResultDto<UserDto>>>> GetUsers([FromQuery] UserPageRequestDto userPageRequestDto)
        {
            //根据用户名搜索，分页返回用户列表

            var result =await _userRepository.GetListAsync(userPageRequestDto);
            return Ok(new AjaxResponse(result));
        }


        /// <summary>
        /// 获取个人信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("Edit")]
        [UnitOfWork(IsTransactional = false)]
        public async Task<IActionResult> GetUser([FromQuery]NullableIdDto<long> idDto)
        {
            var output = await _userRepository.GetUserForEdit(idDto);


            return Ok(new AjaxResponse(output));
        }


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userCreateDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<AjaxResponse<UserDto>>> Post([FromBody]UserEditDto userCreateDto)
        {
            var user = _mapper.Map<R_User>(userCreateDto);

            //获取登录的用户
            var userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            var creatorUser = await _userManager.FindByNameAsync(userName);
            ////更新字段
            //user.CreatorId = creatorUser.Id;
            user.EmailConfirmed = true;
            user.NormalizedUserName = user.UserName;
            user.SecurityStamp = DateTime.Now.Ticks.ToString();

            //密码
            PasswordHasher<R_User> ph = new PasswordHasher<R_User>();
            user.PasswordHash = ph.HashPassword(user, userCreateDto.Password);

            //添加用户
            var result = await _userManager.CreateAsync(user);
            var dto=_mapper.Map<UserDto>(user);


            if (result.Succeeded)
            {
                return Created(string.Empty, new AjaxResponse(dto) );
            }
            else
            {
                var responseResult = new AjaxResponse(new ErrorInfo("请检查用户账号，是否重复！"));
                return BadRequest(responseResult);
            }
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userUpdateDto"></param>
        /// <returns></returns>
        [HttpPut("id")]
        public async Task<IActionResult> Put(long id, [FromBody] UserUpdateDto userUpdateDto)
        {

            //获取用户
            var responseResult = new AjaxResponse();
            var rUser = await _userManager.FindByIdAsync(id.ToString());
            if (rUser == null)
            {
                return BadRequest(responseResult);
            }

            //更新密码
            if (userUpdateDto.Password == null)
            {
                userUpdateDto.Password = rUser.PasswordHash;
            }
            else
            {
                PasswordHasher<R_User> passwordHasher = new PasswordHasher<R_User>();
                rUser.PasswordHash = passwordHasher.HashPassword(rUser, userUpdateDto.Password);
            }

            //更新字段
            _mapper.Map(userUpdateDto, rUser);
            rUser.LastModificationTime = DateTime.Now;
            var result = await _userManager.UpdateAsync(rUser);
            if (!result.Succeeded)
            {
                return BadRequest();
            }

            //删除原本角色
            var oldRoles = await _userManager.GetRolesAsync(rUser);
            if (oldRoles != null && oldRoles.Count > 0)
            {
                await _userManager.RemoveFromRolesAsync(rUser, oldRoles);
            }

            //设置新角色
            result = await _userManager.AddToRolesAsync(rUser, userUpdateDto.RoleNames);

            if (result.Succeeded)
            {
                return NoContent();
            }
            else
            {
                return BadRequest();
            }

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(long id)
        {
            var responseResult = new AjaxResponse();
            var rUser = await _userManager.FindByIdAsync(id.ToString());

            if (id == 1)
            {
                return BadRequest(responseResult);
            }
            else if (rUser == null)
            {
                return BadRequest(responseResult);
            }

            await _userManager.DeleteAsync(rUser);
            return NoContent();

        }
    }



}
