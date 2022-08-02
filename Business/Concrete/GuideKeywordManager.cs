using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.ComplexTypes;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class GuideKeywordManager : IGuideKeywordService
    {
        IGuideKeywordDal _guideKeywordDal = new EfGuideKeywordDal();

        public string Add(GuideKeyword gk)
        {
            try
            {
                _guideKeywordDal.Add(gk);
            }
            catch (System.Exception e)
            {
                return e.Message;
                throw;
            }
            return "Ok";
        }

        public List<GuideKeyword> GetAll()
        {
            return _guideKeywordDal.GetList();
        }

        public List<GuideKeyword> GetById(int id)
        {
            //return _guideKeywordDal.GetGuideKeywordsByKeywordId(id);
            return _guideKeywordDal.GetList(p=> p.Id == id);
        }

        public List<GuideKeywords> GetGuideKeywordsByGuide(int guideId)
        {
            return _guideKeywordDal.GetGuideKeywordsByGuide(guideId);
        }

        public List<GuideKeyword> GetGuideKeywordsByKeywordId(int keywordId)
        {
            return _guideKeywordDal.GetList(p => p.KeywordId == keywordId);
        }

        public List<GuideKeywords> GetGuideKeywordsByLanguage(int languageId)
        {
            return _guideKeywordDal.GetGuideKeywordsByLanguage(languageId);
        }

        public List<GuideKeyword> GetGuideKeywordsBySearchKeyword(string searchKeyword, int languageId)
        {
            return _guideKeywordDal.GetGuideKeywordsBySearchKeyword(searchKeyword, languageId);
        }
    }

}
