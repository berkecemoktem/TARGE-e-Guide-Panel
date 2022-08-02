using Core.DataAccess;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IGuideDal:IEntityRepository<Guide>
    {
        // Custom Operations (Only Guide Op.)

        public Guide AddedGuide(Guide guide);

        public List<GuideContent> GetByIds(List<GuideKeyword>guideIds,int languageId, int platformId);

        public GuideContent GetGuideTitleByUrl(int languageId, int platformId, string url);
        List<GuideContent> GetTitleByLanguage(int languageId, int platformId); // Guide Title 

        List<Guide> GetGuideByIds(List<GuideKeyword> guideIds,int languageId);

    }
}
