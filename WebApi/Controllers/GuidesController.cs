using Business.Abstract;
using Core.Utilities.Results.ErrorResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuidesController : ControllerBase
    {
        // Guide Api -- İç
        IGuideService _guideService;
        public GuidesController(IGuideService guideService)
        {
           _guideService = guideService;
        }

        [HttpGet] 
        public IActionResult GetAll(int languageId)// 
        {
            // Get All guide content and guide titles

            var guideService= _guideService.GetAll();

            return BadRequest(new ErrorResult("Sistem bakımda"));
        }

        public IActionResult GetById()
        {
            return null;
        }

       
    }
}
