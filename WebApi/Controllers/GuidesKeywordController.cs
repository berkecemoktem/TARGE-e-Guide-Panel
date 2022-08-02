using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GuidesKeywordController : Controller
    {
        IGuideKeywordService _guideKeywordService;
        public GuidesKeywordController(IGuideKeywordService guideKeywordService)
        {
            _guideKeywordService = guideKeywordService;
        }

        //getir.
        [HttpGet]
        [Route("/api/guidekeyword/get")]
        public IActionResult Get()
        {
            var res = _guideKeywordService.GetAll();
            return Ok(res);
        }

        //id'ye göre getir.
        [HttpGet]
        [Route("/api/guidekeyword/getbyid/{guideKeywordId}")]
        public IActionResult GetById(int guideKeywordId)
        {
            var res = _guideKeywordService.GetById(guideKeywordId);
            return Ok(res);
        }

        //guide id'ye göre getir.
        [HttpGet]
        [Route("/api/guidekeyword/getbyguideid/{guideId}")]
        public IActionResult GetByGuideId(int guideId)
        {
            var res = _guideKeywordService.GetGuideKeywordsByGuide(guideId);
            return Ok(res);
        }

        //keyword id'ye göre getir.
        [HttpGet]
        [Route("/api/guidekeyword/getbykeywordid/{keywordId}")]
        public IActionResult GetByKeywordId(int keywordId)
        {
            var res = _guideKeywordService.GetGuideKeywordsByKeywordId(keywordId);
            return Ok(res);
        }

        //ekle.
        [HttpPost]
        [Route("/api/guidekeyword/add")]
        public IActionResult Add([FromBody]GuideKeyword gk)
        {
            var res = _guideKeywordService.Add(gk);
            return Ok(res);
        }
    }
}
