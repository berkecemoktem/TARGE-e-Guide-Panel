
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Language;
using DataAccess.Concrete.EntityFramework;
using Entities.ComplexTypes;
using Entities.Concrete;
using GuideUI.Entities;
using GuideUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GuideUI.Controllers
{
    public class DevicesController : Controller
    {

        // 

        ICategoryService _categoryManager = new CategoryManager();
        IContentService _contentManager= new ContentManager(new EfContentDal());
        IGuideService _guideManager = new GuideManager(new EfGuideDal());
        IDocumentService _documentService = new DocumentManager();
        IRoutingService _routingManager = new RoutingManager();
        ILanguageService _languageManager = new LanguageManager(new EfLanguageDal());    //Depencendy Chain ..
        IPlatformService _platformManager = new PlatformManager();
        IGuideKeywordService _guideKeywordManager = new GuideKeywordManager();
        ISystemLanguageService _systemLanguageManager;
        

        public DevicesController()
        {
            

        }

        public string Index()
        {
            return "a";
        }

        [Route("/{languageName}/{platformName}/{url}")]
        //[Route("{language?}/device/{url?}")]


        public IActionResult GetDeviceUrl(string languageName,string platformName,string url)
        {


            var Language = _languageManager.GetLanguageByShortTitle(languageName);
            var Platform = _platformManager.GetPlatformByName(platformName);

            if (Platform == null || Language == null)
            {
                return BadRequest();
            }

            switch (languageName)
            {
                case "tr":
                    _systemLanguageManager = new SystemLanguageManager(new TurkishLanguage());
                    break;
                case "en":
                    _systemLanguageManager = new SystemLanguageManager(new EnglishLanguage());
                    break;
                default:

                    break;
            }

            GuideContent GuideContent = _guideManager.GetGuideTitleByUrl(Language.LanguageId, Platform.PlatformId, url); // guide ve content tablosunu join edip aldığı parametrelere göre içerik döndürür..

            if (GuideContent == null)
            {
                return BadRequest();
            }

            Guide guide = _guideManager.GetById(GuideContent.GuideId);

            // Keywords Content Keywords 
            var Keywordsss = _guideKeywordManager.GetGuideKeywordsByGuide(guide.GuideId);


            var dataView = new GuideListData
            {

                Categories = _categoryManager.GetCategories(Language.LanguageId),
                Titles = _guideManager.GetTitleByLanguage(Language.LanguageId, Platform.PlatformId),
                Content = GuideContent,
                Documents = _documentService.GetDocumentByGuide(GuideContent.GuideId, Language.LanguageId),
                CurrentPlatform = Platform.PlatformName,
                OtherPlatforms = _platformManager.GetPlatformByLanguage(Language.LanguageId),
                CurrentCategory = _categoryManager.GetCategory(guide.CategoryId),
                Routings = _routingManager.GetRoutingByGuide(guide.GuideId),
                CurrentLanguage = languageName,
                Keywords = _guideKeywordManager.GetGuideKeywordsByGuide(guide.GuideId),
                SystemLanguage = _systemLanguageManager

            };

            return View(dataView);
        }

        public string NotFound()
        {
            return "bos geldi";
        }
        
    }
}
