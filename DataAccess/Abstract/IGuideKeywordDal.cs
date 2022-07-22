using Core.DataAccess;
using Entities.Concrete;
using Entities.ComplexTypes;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IGuideKeywordDal : IEntityRepository<GuideKeyword>
    {
        // Custom Operations (Only Guide Op.)
        public List<GuideKeywords> GetGuideKeywordsByLanguage(int languageId);
        public List<GuideKeyword> GetGuideKeywordsByKeywordId(int keywordId);
        public List<GuideKeywords> GetGuideKeywordsByGuide(int guideId);
        public List<GuideKeyword> GetGuideKeywordsBySearchKeyword(string searchKeyword ,int languageId);
    }
}
