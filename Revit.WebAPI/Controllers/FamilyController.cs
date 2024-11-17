using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Revit.Service.Families;
using Revit.Entity.Family;
using Revit.Shared.Entity.Commons;
using Revit.Shared.Entity.Family;
using Abp.Web.Models;

namespace Revit.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FamilyController : ControllerBase
    {
        private readonly IFamilyService familyService;
        private readonly IFamiyCategoryService famiyCategoryService;

        public FamilyController(IFamilyService familyService)
        {
            this.familyService = familyService;
            this.famiyCategoryService = famiyCategoryService;
        }

        //[HttpGet]
        //public async Task<ActionResult<R_Family>> GetFamilyAsync(long familyId)
        //{
        //    var family = await familyService.GetAsync(familyId);
        //    if (family is null)
        //    {
        //        return NoContent();
        //    }

        //    var familyDto = Mapper.Map<R_Family, FamilyDto>(family);
        //    return Ok(familyDto);
        //}

        [HttpGet]
        public async Task<ActionResult<AjaxResponse>> GetAsync(
            [FromQuery] FamilyPageRequestDto parameters)
        {
            var pageList = await familyService.GetListAsync(parameters);
            return Ok(new AjaxResponse(pageList));
        }

        [HttpGet("User/{userId}")]
        public async Task<ActionResult<AjaxResponse<IListResult<FamilyDto>>>> GetFamiliesAsync(long userId)
        {
            var families = await familyService.GetFamiliesByUser(userId);
            return Ok(new AjaxResponse(families));
        }

        [HttpPost("User/{creatorId}")]
        public async Task<ActionResult<AjaxResponse<IListResult<FamilyDto>>>> UploadFamily([FromRoute] long creatorId)
        {
            var families = await familyService.UploadFiles(creatorId, new FamilyUploadDto() { Files = Request.Form.Files });
            if (families == null) return NotFound();
            return Ok(new AjaxResponse(families));
        }

        [HttpGet("{familyId}")]
        public async Task<ActionResult<AjaxResponse<byte[]>>> DownloadFamily(long familyId)
        {
            var stream = await familyService.DownloadFamily(familyId);
            if (stream == null) return NotFound();
            return Ok(new AjaxResponse(stream));
        }

        [HttpPut("{familyId}")]
        public async Task<ActionResult<AjaxResponse<FamilyDto>>> AuditingFamily(long familyId, FamilyPutDto familyPutDto)
        {
            var result = await familyService.AuditingFamily(familyId, familyPutDto);
            if (result == null) return NotFound();
            return Ok(new AjaxResponse(result));
        }



    }
}