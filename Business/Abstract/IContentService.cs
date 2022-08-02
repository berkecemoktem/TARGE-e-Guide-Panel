using Business.Concrete;
using Entities.ComplexTypes;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContentService
    {
        string Add(Content content);
        List<Content> GetAll();
        List<Content> GetByGuide(int guideId);
        List<Content> GetById(int id);
        List<Content> GetByPlatform(int platformId);
        List<GuideContent> GetGuideContentByLanguageAndPlatform(int languageId, int platformId);// Guide Title 
        GuideContent GetGuideTitleByUrl(int languageId, int platformId,string url);// Guide Title 
        Content Get();
        List<GuideContent> GetTitleByLanguage(int languageId, int platformId); // Guide Title 
        List<GuideContent> GetGuideContentsByGuideId(List<GuideKeywords> guideId);
        List<ContentPlatform> GetByGuides(List<GuideKeyword> guidesId,int languageId);

    }

}
