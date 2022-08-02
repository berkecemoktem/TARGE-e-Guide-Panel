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
    public class ContentManager : IContentService
    {

        private IContentDal _contentDal;  // EFContentDal 

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }


        public List<Content> GetAll()
        {
           return _contentDal.GetList();

        }

        public List<Content> GetByGuide(int guideId)
        {
            return _contentDal.GetList(p => p.GuideId == guideId); //içerisinde link operasyonunu 
        }

        public List<GuideContent> GetTitleByLanguage(int languageId,int platformId)
        {
            return _contentDal.GetTitlesByLanguage(languageId, platformId);

        }
        public List<Content> GetById(int id)
        {
            return _contentDal.GetList(p => p.ContentId == id); 
        }

        public List<Content> GetByPlatform(int platformId)
        {
            return _contentDal.GetList(p => p.PlatformId == platformId);
        }

        public List<GuideContent> GetGuideContentByLanguageAndPlatform(int languageId, int platformId)
        {
            return _contentDal.guideContentsByLanguageAndPlatform(languageId, platformId);

        }

        public GuideContent GetGuideTitleByUrl(int languageId, int platformId, string url)
        {
            
            return _contentDal.GetGuideTitleByUrl(languageId, platformId, url);

        }

        public Content Get()
        {
            
            throw new NotImplementedException();
        }

        public List<GuideContent> GetGuideContentsByGuideId(List<GuideKeywords> guideId)
        {
            return _contentDal.GetGuideContentsByGuideId(guideId);
        }

        public List<ContentPlatform> GetByGuides(List<GuideKeyword> guidesId,int languageId)
        {
            return _contentDal.GetByGuides(guidesId,languageId);
        }

        public string Add(Content content)
        {
            try
            {
               _contentDal.Add(content);
            }
            catch (Exception e)
            {
                return e.Message;
                throw;
            }
            return "ekleme basarili";
        }
    }

}
