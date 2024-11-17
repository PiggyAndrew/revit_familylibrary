using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Revit.Entity.Users;
using Revit.Shared.Entity.Auths;
using Revit.Shared.Entity.Commons;
using Revit.WebAPI.Auth;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Abp.Web.Models;
using Revit.Shared.Entity.Auths.Dto;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthsController : ControllerBase
    {
        private readonly SignInManager<R_User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public AuthsController(SignInManager<R_User> signInManager, IMapper mapper, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            this._signInManager = signInManager;
            this._mapper = mapper;
            this._httpContextAccessor = httpContextAccessor;
            this._configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthenticateModel loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserNameOrEmailAddress, loginDto.Password, false, false);
            if (result.Succeeded)
            {
                var claim = new[] {
                new Claim(ClaimTypes.Name,loginDto.UserNameOrEmailAddress) };

                var jwtBearer = _configuration.GetSection(AppSettings.Autherization).GetSection(AppSettings.JwtBearer);
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtBearer.GetValue<string>(AppSettings.SecurityKey)));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var securityToken = new JwtSecurityToken(
                    issuer: jwtBearer.GetValue<string>(AppSettings.Issuer),
                    audience: jwtBearer.GetValue<string>(AppSettings.Audience),
                    claims: claim,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds
                    );

                var token = new JwtSecurityTokenHandler().WriteToken(securityToken);

                var value = this.Request.HttpContext.User.Identity;
                return Ok(new AjaxResponse(new AuthenticateResultModel(){AccessToken = token}) );
            }
            return BadRequest(new AjaxResponse(new ErrorInfo("账号不存在或密码错误")));
        }
    }
}
