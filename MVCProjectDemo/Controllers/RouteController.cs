using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using MVCProjectDemo.Models;

namespace MVCProjectDemo.Controllers
{

          

    public class RouteController : Controller
    {

        ILanguageService _languageManager = new LanguageManager(new EfLanguageDal());
        public IActionResult Index()
        {
            var dataView = new LanguageViewModel
            {
                Languages = _languageManager.GetLanguages()
            };

            return View(dataView);
        }

        
        

            
       

    }
}
