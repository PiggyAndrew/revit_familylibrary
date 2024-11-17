using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Service.Projects;
using Revit.WebAPI.Auth;
using Revit.WebAPI.UnitOfWork;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Project/{projectId}/Folder")]
    [AllowAnonymous]
    [UnitOfWork(IsTransactional = false)]
    public class ProjectsFolderController : ControllerBase
    {
        private readonly IProjectFolderService projectFolderService;

        public ProjectsFolderController(IProjectFolderService projectFolderService)
        {
            this.projectFolderService = projectFolderService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProjectFolders(long projectId, [FromQuery] ProjectGetFoldersDto projectGetFoldersDto)
        {
            var result = projectFolderService.GetProjectPathFolders(projectId,projectGetFoldersDto);
            if (result != null && result.Count > 0)
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetNotFound());
        }

        [HttpPost]
        public async Task<IActionResult> CreateProjectFolder(long projectId, ProjectCreateFolderDto projectCreateFolderDto)
        {
            var result = projectFolderService.CreateProjectFolder(projectId,projectCreateFolderDto);
            if (result != null )
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetError());
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProjectFolder(long folderId)
        {
            var result = projectFolderService.DeleteProjectFolder(folderId);
            if (result >0)
            {
                return Ok(new ResponseResultDto());
            }
            return NotFound(new ResponseResultDto().SetError());
        }

    }
}
