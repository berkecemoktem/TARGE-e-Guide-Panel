using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCProjectDemo.Models;

namespace MVCProjectDemo.Controllers
{
    public class DeviceController : Controller
    {
        ICategoryService _categoryManager = new CategoryManager();
        ILanguageService _languageManager = new LanguageManager(new EfLanguageDal());
        IContentService _contentManager = new ContentManager(new EfContentDal());

        public DeviceController()
        {
            
        }

        [Route("tr/cihaz/{id}")]
        [Route("en/device/{id}")]
        public IActionResult Index(string url)
        {
            string lang = "tr";
            string platform = "cihaz";
            switch (lang)
            {
                case "tr": lang = "1";
                    break;
                case "en": lang = "2"; 
                    break;
                default: lang = "1";
                    break;
            }

            //urlden gelen değerin ilkine bak o değere sorgu calistir.
            // Category - Language - Guide Single Content - -Guide Title- - Document - Routing -
            // 

            var Guides = new GuideListViewModel
            {
                GuideTitles = _contentManager.GetTitleByLanguage(Convert.ToInt32(lang)), // Dil numarasına göre başlıklar gelir
                Guides = _contentManager.GetGuideTitleByUrl(Convert.ToInt32(lang), platform ,url), // Urle göre içerik gelir
                Categories = _categoryManager.GetCategories(Convert.ToInt32(lang)).Select(x => new SelectListItem { Text = x.Title, Value = x.CategoryId.ToString()}).ToList(),
                Languages = _languageManager.GetLanguages().Select(x => new SelectListItem { Text = x.Title, Value = x.LanguageId.ToString()}).ToList()

            };



            return View(Guides);

        }

        public IActionResult Search()
        {
            return null;
        }

    }


}
