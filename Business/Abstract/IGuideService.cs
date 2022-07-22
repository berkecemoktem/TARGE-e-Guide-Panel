using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGuideService
    {
        List<Guide> GetAll();
        List<Guide> GetByLanguage(int languageId);
        List<Guide> GetByCategory(int categoryId);
        Guide GetById(int guideId);
        List<GuideContent> GetByIds(List<GuideKeyword> guideIds, int languageId ,int platformId);
        List<Guide> GetByIds(List<GuideKeyword> guideIds, int languageId);

        GuideContent GetGuideTitleByUrl(int languageId, int platformId, string url);
        List<GuideContent> GetTitleByLanguage(int languageId, int platformId); // Guide Title 


    }

}
