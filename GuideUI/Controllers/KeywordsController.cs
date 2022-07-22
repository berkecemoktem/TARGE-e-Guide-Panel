using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Language;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using GuideUI.Models;
using Microsoft.AspNetCore.Mvc;


namespace GuideUI.Controllers
{
    public class KeywordsController : Controller
    {


        ILanguageService _languageManager = new LanguageManager(new EfLanguageDal());
        IGuideKeywordService _guideKeywordManager = new GuideKeywordManager();
        IContentService _contentManager = new ContentManager(new EfContentDal());
        ICategoryService _categoryManager = new CategoryManager();
        IPlatformService _platformManager = new PlatformManager();
        IGuideService _guideManager = new GuideManager(new EfGuideDal());
        ISystemLanguageService _systemLanguageManager;
        IKeywordService _keywordManager = new KeywordManager();
         



        public string Index()
        {
            return "index";
        }

        [Route("{lang}/{platformName}/keywords/{id}")]
        [Route("{lang}/{platformName}/anahtarlar/{id}")]

        public IActionResult Key(string lang, string platformName, int id) //tr/cihaz/anahtarlar/1 == tr/mobil/anahtarlar/1 içerik kısımları eşit değişkenlik göstermeyecek. 
        {
            //platform => aside için dizgi oluşturacak .. 
            //lang => aside title için gerekli
            //


            var language = _languageManager.GetLanguageByShortTitle(lang);
            var platform = _platformManager.GetPlatformByName(platformName);

            if (platform == null || language == null)
            {
                return BadRequest();
            }

            switch (lang)
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

            List<GuideKeyword> guideKeyword = _guideKeywordManager.GetGuideKeywordsByKeywordId(id); // Language id and Keyword id  // Ca

            if (guideKeyword == null)
            {
                return BadRequest();
            }

            var Titles = _guideManager.GetTitleByLanguage(language.LanguageId, platform.PlatformId);
            if (Titles == null || Titles.Count == 0)
            {
                return BadRequest();
            }

            var guideTitles = _guideManager.GetByIds(guideKeyword, language.LanguageId,platform.PlatformId);

            var content = _contentManager.GetByGuides(guideKeyword, language.LanguageId); //icerik gelsin..

            

            if (content == null || content.Count == 0)
            {
                return BadRequest();
            }
            // Guide

            //tr/mobil/anahtarlar/1

           

            var dataView = new KeywordListData
            {
                Content = content,
                Categories = _categoryManager.GetCategories(language.LanguageId),// category Guide tablos
                Titles = Titles,
                CurrentLanguage = lang,
                CurrentPlatform = platform.PlatformName,
                GuideTitles = guideTitles,
                SystemLanguage = _systemLanguageManager,
                Platforms = _platformManager.GetPlatformByLanguage(language.LanguageId),
                KeywordId=id.ToString(),
        };





            // 11,12,13,14 





            return View(dataView);
        }



        [Route("{lang}/keywords/{searchKey}")]  // //tr/cihaz/anahtarlar/iklimdirme
        [Route("{lang}/anahtarlar/{searchKey}")]
        public IActionResult SearchKey(string lang,string searchKey)
        {
            var language = _languageManager.GetLanguageByShortTitle(lang);

            if (language == null)
            {
                return BadRequest();
            }

            switch (lang)
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

            //search keyi language id ile birlikte parametre olarak keyworde gönder sana geriye guide title döndürsün.

            List<GuideKeyword> guideKeywords = _guideKeywordManager.GetGuideKeywordsBySearchKeyword(searchKey, language.LanguageId);// List Guide Keyword döndürür

            var guideTitles = _guideManager.GetByIds(guideKeywords, language.LanguageId);
            var Contents = _contentManager.GetByGuides(guideKeywords, language.LanguageId);

            if(guideTitles == null)
            {
                return BadRequest();
            }

            var dataView = new KeywordListData
            {
                Content = Contents,
                Categories = _categoryManager.GetCategories(language.LanguageId),// category Guide tablos
                CurrentLanguage = lang,
                Guides = guideTitles,
                SystemLanguage = _systemLanguageManager,
                Platforms = _platformManager.GetPlatformByLanguage(language.LanguageId),
                
            };



            return View(dataView);
        }
    }
}
