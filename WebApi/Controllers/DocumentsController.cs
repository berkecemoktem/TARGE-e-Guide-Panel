using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        IDocumentService _documentService;
        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        [Route("/api/document/get")]
        public IActionResult Get()
        {
            var res = _documentService.GetAll();
            return Ok(res);
        }

        //guide id ile filtreleme
        [HttpGet]
        [Route("/api/document/getbyguideid/{guideId}")]
        public IActionResult GetByGuideId(int guideId)
        {
            var res = _documentService.GetDocumentByGuideId(guideId);
            return Ok(res);
        }

        //language id ile filtreleme
        [HttpGet]
        [Route("/api/document/getbylanguageid/{languageId}")]

        public IActionResult GetByLanguageId(int languageId)
        {
            var res = _documentService.GetDocumentByLanguageId(languageId);
            return Ok(res);
        }

        //hem language id hem de guide id ile filtreleme
        //NOT: ÇALIŞMIYOR
        [HttpGet]
        [Route("/api/document/getbylanguageandguide/{guideId}/{languageId}")]
        public IActionResult GetByLanguageAndGuide(int guideId, int languageId)
        {
            var res = _documentService.GetDocumentByGuideAndLanguage(guideId, languageId);
            return Ok(res);
        }

        [HttpPost]
        [Route("/api/document/add")]
        public IActionResult Add(Document d)
        {
            var res = _documentService.Add(d);
            return Ok(res);
        }
    }
}
