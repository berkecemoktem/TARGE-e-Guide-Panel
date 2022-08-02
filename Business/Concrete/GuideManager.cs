using Business.Abstract;
using Core.Utilities.Results;
using Core.Utilities.Results.ErrorResults;
using Core.Utilities.Results.SuccessResults;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDAL;
        public GuideManager(IGuideDal guideDal)
        {
            _guideDAL = guideDal;
        }
      
        public List<Guide> GetAll()
        {
            return _guideDAL.GetList();
        }

        public List<Guide> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Guide GetById(int guideId)
        {
            return _guideDAL.Get(p=> p.GuideId == guideId);
        }

        public List<GuideContent> GetByIds(List<GuideKeyword> guideIds, int languageId,int platformId)
        {
             
            return _guideDAL.GetByIds(guideIds,languageId,platformId);
        }

        public List<Guide> GetByIds(List<GuideKeyword> guideIds, int languageId)
        {
            return _guideDAL.GetGuideByIds(guideIds, languageId);

        }

        public List<Guide> GetByLanguage(int languageId)
        {
            throw new NotImplementedException();
        }

        public GuideContent GetGuideTitleByUrl(int languageId, int platformId, string url)
        {
            return _guideDAL.GetGuideTitleByUrl(languageId, platformId, url);
        }

        public List<GuideContent> GetTitleByLanguage(int languageId, int platformId)
        {
            return _guideDAL.GetTitleByLanguage(languageId, platformId);
        }
        public string Add(Guide guide)
        {
            try { 
                _guideDAL.Add(guide);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }

        public List<Guide> GetByCategoryId(int categoryId)
        {
            return _guideDAL.GetList(p => p.CategoryId == categoryId);
        }

        public List<Guide> GetByLanguageId(int languageId)
        {
            return _guideDAL.GetList(p=> p.LanguageId == languageId);
        }

        public List<Guide> GetByTitle(string title)
        {
            return _guideDAL.GetList(p=> p.Title == title);
        }

        public Guide GetByUrl(string url)
        {
            return _guideDAL.Get(p=> p.Url == url);
        }

        public IDataResult<Guide> AddedGuide(Guide g)
        {
            if(!(g.CategoryId == null || g.LanguageId == null || g.Title == null || g.Url == null))
            {
                GenerateUrl(g);
                var r = _guideDAL.AddedGuide(g);
                return new SuccessDataResult<Guide>(r, true, "Guide Eklendi.");

            }
            
            return new ErrorDataResult<Guide>(g,"başarısız");
        }

        //refactor edilecek
        public string GenerateUrl(Guide g)
        {          
            g.Url = g.Title.Replace(' ', '-');
            List<Guide> guideList = _guideDAL.GetList(p => p.Url == g.Url);
            if (guideList.Count > 0)
            {
                Random random = new Random();
                int random_number = random.Next(100, 999);
                g.Url = g.Url + random_number.ToString();
                
            }
            return g.Url;
        }

       
    }
}
