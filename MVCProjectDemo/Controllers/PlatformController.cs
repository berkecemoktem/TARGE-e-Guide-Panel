using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MVCProjectDemo.Controllers
{

    

    public class PlatformController : Controller
    {
        ICategoryService _categoryManager = new CategoryManager();
        IContentService _contentManager = new ContentManager(new EfContentDal());

        public IActionResult Index(string platform, string title,string language)//web/language/title
        {
           var guideContents= _contentManager.GetGuideContentByLanguageAndPlatform(2, "web");
            // Bir tane view sayfası çağırreturn   
            return Json(guideContents);
        }   

    }
}
