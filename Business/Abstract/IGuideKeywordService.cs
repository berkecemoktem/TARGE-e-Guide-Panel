using Entities.ComplexTypes;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IGuideKeywordService
    {
        public string Add(GuideKeyword gk);
        public List<GuideKeyword> GetAll();
        List <GuideKeyword> GetById(int id);
        public List<GuideKeywords> GetGuideKeywordsByLanguage(int languageId);
        public List<GuideKeyword> GetGuideKeywordsByKeywordId(int keywordId);

        public List<GuideKeywords> GetGuideKeywordsByGuide(int guideId);

        public List<GuideKeyword> GetGuideKeywordsBySearchKeyword(string searchKeyword, int languageId);


    }

}
