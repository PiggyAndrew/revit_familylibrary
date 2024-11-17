using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Revit.Entity.Commons;
using Revit.Entity.Project;
using Revit.Entity.Users;
using Revit.Service.Projects;
using Revit.WebAPI.Auth;
using Revit.WebAPI.Extension;
using Revit.WebAPI.UnitOfWork;
using System.IO;
using System.Text;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/Folder/{folderId}/File")]
    [AllowAnonymous]
    [UnitOfWork(IsTransactional = false)]
    public class ProjectsFileController : ControllerBase
    {
        private readonly IProjectFileService projectFileService;
        private readonly UserManager<R_User> userManager;

        public ProjectsFileController(IProjectFileService projectFileService, UserManager<R_User> userManager)
        {
            this.projectFileService = projectFileService;
            this.userManager = userManager;
        }



        [HttpPost]
        public async Task<IActionResult> UploadProjectFiles(long folderId, [FromForm] ProjectUploadFileDto projectUploadFileDto)
        {
            var user = userManager.FindByNameAsync(this.Request.HttpContext.User.Identity.Name);
            var result = await projectFileService.UploadProjectFile(folderId, user.Result.Id, projectUploadFileDto);
            if (result != null)
            {
                return Ok(new ResponseResultDto(result));
            }
            return NotFound(new ResponseResultDto().SetError());
        }

        [HttpGet]
        public async Task<IActionResult> GetRvtGltfFile(long folderId)
        {
            var basePath = @"C:\Users\Zero\Documents\GitHub\webapi-revitor\Revit.WebAPI\Base\13";

            var savePath = Path.Combine(basePath, "4.gltf");
            var bytes = System.IO.File.ReadAllBytes(savePath);
            var fileStream = new FileStream(savePath, FileMode.Open);
            //var result = await projectFileService.GetRvtGltfFile(folderId);
            if (true)
            {
                //using (var ms = new MemoryStream())
                //{
                //    result.CopyTo(ms);
                //    bytes = ms.ToArray();
                //}
                //string str64 = Encoding.UTF8.GetString(bytes);
                //string ct64 = Convert.ToBase64String(bytes);
                return Ok(new ResponseResultDto(bytes));
            }
            return NotFound(new ResponseResultDto().SetError("未找到该文档，或文档格式不正确。"));

        }




    }
}
