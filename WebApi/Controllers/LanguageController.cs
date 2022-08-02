using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class LanguageController : Controller
    {
        ILanguageService _languageService;
        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService; 
        }

        //tüm verileri çekme
        [HttpGet]
        [Route("/api/language/get")]
        public IActionResult Get()
        {
            var res = _languageService.GetLanguages();
            return Ok(res); 
        }

        //id ile filtreleme
        [HttpGet]
        [Route("/api/language/getbyid/{id}")]       
        public IActionResult GetById(int id)
        {
            var res = _languageService.GetById(id);
            return Ok(res);
        }

        //ekleme
        [HttpPost]
        [Route("/api/language/add")]   
        public IActionResult Add([FromBody]Language lan)
        {
            var res = _languageService.Add(lan);
            return Ok(res);
        }
    }
}
