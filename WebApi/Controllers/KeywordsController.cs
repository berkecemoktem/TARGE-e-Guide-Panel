using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class KeywordsController : ControllerBase
    {
    
        IKeywordService _keywordService;
        public KeywordsController(IKeywordService keywordService)
        {
            _keywordService = keywordService;
        }

       /* [HttpGet]
        [Route("/api/keyword/getbysearchkey")]
        public IActionResult GetBySearchKey(String searchKey, int languageId)
        {
            var res = _keywordService.GetKeywordsBySearchKey(searchKey, languageId);
            return Ok(res);

        }*/

        //get method
        [HttpGet]
        [Route("/api/keyword/get")]
        public IActionResult Get()
        {
            var res = _keywordService.GetAll();
            return Ok(res);

        }

        //id ile filtreleme.
        [HttpGet]
        [Route("/api/keyword/getbyid/{keywordId}")]
        public IActionResult GetById(int keywordId)
        {
            var res = _keywordService.GetById(keywordId);
            return Ok(res);

        }

        //language id ile filtreleme.
        //404!!!
        [HttpGet]
        [Route("/api/keyword/getbylanguageid/{languageId}")] 
        public IActionResult GetByLanguageId(int languageId)
        {

            var res = _keywordService.GetByLanguageId(languageId);
            return Ok(res);

        }


        //Post  method for keywords
        [HttpPost]
        [Route("/api/keyword/add")]       
        public IActionResult Add([FromBody]Keyword k)
        {
            var res = _keywordService.Add(k);
            return Ok(res);
        }


        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
