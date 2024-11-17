using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Crmf;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Service.Projects;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    [UnitOfWork(IsTransactional = false)]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService projectService;

        /// <summary>
        /// 项目控制类
        /// </summary>
        /// <param name="projectService"></param>
        public ProjectsController(IProjectService projectService)
        {
            this.projectService = projectService;
        }


        [HttpGet]
        public IActionResult Get([FromQuery] ProjectRequestDto pageRequest)
        {
            var result = projectService.GetProjects(pageRequest);
            if (result != null && result.Any())
            {
                return Ok(new ResponseResultDto() { Content = result, Code = ResponseCode.Success });
            }
            else
            {
                return BadRequest(new ResponseResultDto() { Code = ResponseCode.NotFound, Message = "该项目无成员。" });
            }
        }

        [HttpGet("{projectId}/Users")]
        public IActionResult GetUsers(long projectId)
        {
            var result = projectService.GetProjectUsers(projectId);
            if (result != null && result.Any())
            {
                return Ok(new ResponseResultDto() { Content = result, Code = ResponseCode.Success });
            }
            else
            {
                return BadRequest(new ResponseResultDto() { Code = ResponseCode.NotFound, Message = "该项目无成员。" });
            }


        }

        [HttpDelete("{projectId}/Users/{userId}")]
        public IActionResult GetUsers(long projectId, long userId)
        {
            var result = projectService.DeleteProjectUser(projectId, userId);
            if (result > 0)
            {
                return Ok(new ResponseResultDto() { Content = result, Code = ResponseCode.Success });
            }
            else
            {
                return BadRequest(new ResponseResultDto() { Code = ResponseCode.NotFound, Message = "删除失败。" });
            }
        }

        [HttpDelete("{projectId}/User/{userId}")]
        public IActionResult DeleteProjectUser(long projectId, long userId)
        {
            var result = projectService.DeleteProjectUser(projectId, userId);
            if (result > 0)
            {
                return Ok(new ResponseResultDto() { Content = result, Code = ResponseCode.Success });
            }
            else
            {
                return BadRequest(new ResponseResultDto() { Code = ResponseCode.NotFound, Message = "该项目无成员。" });
            }
        }


        /// <summary>
        /// 创建项目
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<ProjectResponseDto>> PostAsync([FromForm] ProjectPostPutDto projectCreateDto)
        {
            var result = await projectService.CreateProject(projectCreateDto);

            if (result != null)
            {
                return Ok(new ResponseResultDto(result));
            }
            else
            {
                return NoContent();
            }
        }

        [HttpDelete("{projectId}")]
        public ActionResult<ResponseResultDto> Delete(long projectId)
        {
            var deleteCount = projectService.DeleteProject(projectId);
            if (deleteCount > 0)
            {
                return Ok(new ResponseResultDto());
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPost("{projectId}/User/{userId}")]
        public ActionResult<ResponseResultDto> AddProjectUser(long projectId, long userId)
        {
            var result = projectService.AddProjectUser(projectId, userId);
            if (result != null)
            {
                return Ok(new ResponseResultDto(result));
            }
            else
            {
                return NoContent();
            }
        }


        [HttpPut]
        private async Task<ActionResult<ResponseResultDto>> Put([FromForm] ProjectPostPutDto projectModify)
        {
            var result = projectService.ModifyProject(projectModify);
            if (result > 0)
            {
                return Ok(new ResponseResultDto(result));
            }
            else
            {
                return NoContent();
            }

        }


        [HttpGet("Files")]
        public async Task<ActionResult<ResponseResultDto>> GetRecentlyFiles([FromQuery] long userId)
        {
            var result = projectService.GetRecentlyFiles(userId);
            if (result != null)
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetError());
        }




    }
}
