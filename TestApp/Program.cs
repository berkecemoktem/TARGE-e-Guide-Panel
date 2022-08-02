using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.Hidden;
//using DataAccess.Concrete.AdoNet;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace TestApp
{
    public class Program
    {
        static CategoryManager _categoryManager = new CategoryManager();
        static ILanguageService _languageManager = new LanguageManager(new EfLanguageDal());
        static IPlatformService _platformManager = new PlatformManager();
        static IContentService _contentManager = new ContentManager(new EfContentDal());
        static IGuideKeywordService _guideManager  = new GuideKeywordManager();


        static void Main(string[] args)
        {
            testApp();
        }

        public static void testApp()
        {
            //var ab = _contentManager.GetByGuides();
            //if (ab != null)
            //{
            //    foreach (var item in ab)
            //    {
            //        Console.WriteLine(item.Title);
            //    }

            //}





        }
    }
}
