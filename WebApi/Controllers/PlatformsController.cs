using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class PlatformsController : Controller
    {
       
        IPlatformService _platformService;
        public PlatformsController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        //tüm verileri çekme
        [HttpGet]
        [Route("/api/platform/get")]
        public IActionResult Get(Platform p)
        {
            var res = _platformService.GetAll();
            return Ok(res);
     
        }

        //id ile filtreleme
        [HttpGet]
        [Route("/api/platform/getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            var res = _platformService.GetById(id);
            return Ok(res);

        }

        //dile göre filtreleme
        [HttpGet]
        [Route("/api/platform/getbylanguageid/{languageId}")]
        public IActionResult GetByLanguageId(int languageId)
        {
            var res = _platformService.GetByLanguageId(languageId);
            return Ok(res);

        }

        //hem dil hem de platform id'ye göre filtreleme
        [HttpGet]
        [Route("/api/platform/getbylanguageandplatform/{languageId}/{platformId}")]
        public IActionResult GetByLanguageIdAndPlatformId(int languageId, int platformId)
        {
            var res = _platformService.GetByLanguageIdAndPlatformId(languageId, platformId);
            return Ok(res);
        }

        //ekleme
        [HttpPost]
        [Route("/api/platform/add")] 
        public IActionResult Add([FromBody]Platform p)
        {
            var res = _platformService.Add(p); 
            return Ok(res); 
        }

        /*public IActionResult GetById()
        {
            return null;
        }*/

       



    }
}

