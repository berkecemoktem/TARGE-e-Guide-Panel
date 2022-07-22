using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGuideKeywordDal : EfEntityRepositoryBase<GuideKeyword, TargeContext>, IGuideKeywordDal
    {
        public List<GuideKeywords> GetGuideKeywordsByGuide(int guideId)
        {
            using (TargeContext db = new TargeContext())
            {
                List<GuideKeywords> guideKeywords = (from gk in db.GuideKeywords
                                                     join guide in db.Guides
                                                     on gk.GuideId equals guide.GuideId
                                                     join keyword in db.Keywords
                                                     on gk.KeywordId equals keyword.KeywordId
                                                     where guide.GuideId == guideId
                                                     select new GuideKeywords
                                                     {
                                                         GuideId = guide.GuideId,
                                                         CategoryId = guide.CategoryId,
                                                         KeywordId = keyword.KeywordId,
                                                         LanguageId = guide.LanguageId,
                                                         Title = keyword.Title,
                                                         IsActive = guide.IsActive,
                                                     }
                                                ).ToList();

                return guideKeywords;
            }

        }

        public List<GuideKeyword> GetGuideKeywordsByKeywordId(int keywordId)
        {
            using (TargeContext context = new TargeContext())
            {
                return context.GuideKeywords.Where(x => x.KeywordId == keywordId).ToList();
            }
        }

        public List<GuideKeywords> GetGuideKeywordsByLanguage(int languageId)
        {
            using (TargeContext db = new TargeContext())
            {
                List<GuideKeywords> guideKeywords = (from gk in db.GuideKeywords
                                                     join guide in db.Guides
                                                     on gk.GuideId equals guide.GuideId
                                                     join keyword in db.Keywords
                                                     on gk.KeywordId equals keyword.KeywordId
                                                     where guide.LanguageId == languageId
                                                     select new GuideKeywords
                                                     {
                                                         GuideId = guide.GuideId,
                                                         CategoryId = guide.CategoryId,
                                                         KeywordId = keyword.KeywordId,
                                                         LanguageId = guide.LanguageId,
                                                         Title = keyword.Title,
                                                         IsActive = guide.IsActive,
                                                     }
                                                ).ToList();

                return guideKeywords;
            }

        }

        public List<GuideKeyword> GetGuideKeywordsBySearchKeyword(string searchKeyword, int languageId)
        {
            using (TargeContext db = new TargeContext())
            {
                List<GuideKeyword> guideKeywords = (from gk in db.GuideKeywords
                                                    join guide in db.Guides
                                                    on gk.GuideId equals guide.GuideId
                                                    join keyword in db.Keywords
                                                    on gk.KeywordId equals keyword.KeywordId
                                                    where guide.LanguageId == languageId
                                                    where keyword.Title.Contains(searchKeyword)
                                                    select new GuideKeyword
                                                    {
                                                        GuideId = guide.GuideId,
                                                    }
                                                ).ToList();

                return guideKeywords;
            }

        }
    }
}


