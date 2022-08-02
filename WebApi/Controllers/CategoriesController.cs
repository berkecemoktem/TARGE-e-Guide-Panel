using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        //get method
        [HttpGet]
        [Route("api/category/get")]
        public IActionResult Add()
        {
            var res = _categoryService.GetAll();
            return Ok(res);
        }

        //add method
        [HttpPost]
        [Route("api/category/add")]
        public IActionResult Add([FromBody]Category c)
        {
            var res = _categoryService.Add(c);
            return Ok(res);
        }


        //dile göre kategori getir
        [HttpGet]
        [Route("api/category/getbylanguageid/{languageId}")]
        public IActionResult GetByLanguageId(int languageId)
        {
            var result = _categoryService.GetCategories(languageId);
            return Ok(result);
        }


        /*[Route("api/category/getir")]
        [HttpGet]
        public IActionResult Getir(Guide guide)
        {
            var res = _categoryService.GetCategories(guide.LanguageId);
            return Ok(res);
        }*/

        

    }
}
