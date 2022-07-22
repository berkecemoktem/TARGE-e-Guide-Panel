using Core.DataAccess;
using Entities.ComplexTypes;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IContentDal : IEntityRepository<Content> // İçerisine bir content Classı alır. 
    {
        // Custom Operations (Only Content Op.)
        List<GuideContent> guideContentsByLanguageAndPlatform(int languageId , int platformId);
        GuideContent GetGuideTitleByUrl(int languageId ,int platformId, string url);    
        List<GuideContent> GetTitlesByLanguage(int languageId, int platformId);
        List<GuideContent> GetGuideContentsByGuideId(List<GuideKeywords> guideId); 
        List<ContentPlatform> GetByGuides(List<GuideKeyword> guidesId,int languageId);
    }
}
