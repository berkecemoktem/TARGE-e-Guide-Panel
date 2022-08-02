using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentsController : ControllerBase
    {
        IContentService _contentService;

        public ContentsController(IContentService contentService)
        {
            _contentService = contentService;
        }
        [HttpPost]
        [Route("/api/content/add")]
        public IActionResult Add([FromBody]Content c)
        {
            var res = _contentService.Add(c);
            return Ok(res);
        }

        [HttpGet]
        [Route("/api/content/get")]
        public IActionResult Get()
        {
            var res = _contentService.GetAll();
            return Ok(res);
        }

    }
}
