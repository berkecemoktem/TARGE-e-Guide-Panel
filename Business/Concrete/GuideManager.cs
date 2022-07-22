using Business.Abstract;
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
            return null;
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
    }
}
