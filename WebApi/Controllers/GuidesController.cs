using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GuidesController : ControllerBase
    {
        // Guide Api -- İç
        IGuideService _guideService;
        public GuidesController(IGuideService guideService)
        {
            _guideService = guideService;
        }


        [HttpGet]
        [Route("/api/guide/get")]
        public IActionResult GetAll()
        {
            var res = _guideService.GetAll();

            return Ok(res);

        }

        //204: No Content!
        [HttpGet]
        [Route("/api/guide/getbyid/{guideId}")]    
        public IActionResult GetById(int id)
        {
            var res = _guideService.GetById(id);
            return Ok(res);

        }

        //category id ile filtreleme.
        [HttpGet]
        [Route("/api/guide/getbycategoryid/{categoryId}")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var res = _guideService.GetByCategoryId(categoryId);
            return Ok(res);

        }

        //language id ile filtreleme.
        [HttpGet]
        [Route("/api/guide/getbylanguageid/{languageId}")]
        public IActionResult GetByLanguagesId(int languageId)
        {
            var res = _guideService.GetByLanguageId(languageId);
            return Ok(res);

        }

        //title ile filtreleme.
        [HttpGet]
        [Route("/api/guide/getbytitle/{title}")]
        public IActionResult GetByTitle(String title)
        {
            var res = _guideService.GetByTitle(title);
            return Ok(res);

        }

        //url ile filtreleme.
        [HttpGet]
        [Route("/api/guide/getbyurl/{url}")]
        public IActionResult GetByUrl(String url)
        {
            var res = _guideService.GetByUrl(url);
            return Ok(res);

        }

        [HttpPost]
        [Route("/api/guide/add")]
        public IActionResult Add([FromBody]Guide g)
        {
            var res = _guideService.Add(g);

            JsonResult js = new JsonResult(res);
            return js;
            
            //if(guide.IsActive == true)
            //{
            //    guide.IsActive = Convert.ToBoolean(1);
            //}
            //else if(guide.IsActive == false)
            //{
            //    guide.IsActive = Convert.ToBoolean(0);

        }

        [HttpPost]
        [Route("/api/guide/addedguide")]
        public IDataResult<Guide> AddedGuide([FromBody] Guide g)
        {
            IDataResult<Guide> res = _guideService.AddedGuide(g);
            return res;

        }




    }
}
