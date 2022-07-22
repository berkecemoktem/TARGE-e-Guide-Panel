using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfGuideDal : EfEntityRepositoryBase<Guide, TargeContext>, IGuideDal
    {
        public List<GuideContent> GetByIds(List<GuideKeyword> guideIds, int languageId, int platformId)
        {

            //return db.Guides.AsEnumerable().Where(x => guideIds.Any(v => v.GuideId == x.GuideId)).Where(p => p.LanguageId == languageId).ToList();

            using (TargeContext db = new TargeContext())
            {

                List<GuideContent> guideContentsTitle = (from guide in db.Guides
                                                         join content in db.Contents
                                                         on guide.GuideId equals content.GuideId
                                                         where guide.LanguageId == languageId
                                                         where content.PlatformId == platformId
                                                         // where content.IsActive == true
                                                         select new GuideContent
                                                         {
                                                             GuideId = content.GuideId,
                                                             Title = guide.Title,
                                                             PlatformId = content.PlatformId,
                                                             Url = guide.Url,
                                                             Description = content.Description,
                                                             CategoryId = guide.CategoryId,
                                                             LanguageId = guide.LanguageId,
                                                             ContentId = content.ContentId,
                                                             UptadedAt = content.UpdatedAt

                                                         }
                                                    ).AsEnumerable().Where(x => guideIds.Any(v => v.GuideId == x.GuideId)).ToList();

                return guideContentsTitle;


            }


        }

        public List<Guide> GetGuideByIds(List<GuideKeyword> guideIds, int languageId)
        {
            using (TargeContext db = new TargeContext())
            {

                List<Guide> guideContentsTitle = db.Guides.AsEnumerable().Where(x => guideIds.Any(v => v.GuideId == x.GuideId)).ToList();

                return guideContentsTitle;


            }
        }

        public GuideContent GetGuideTitleByUrl(int languageId, int platformId, string url)
        {
            using (TargeContext db = new TargeContext())
            {

                GuideContent guideContentsTitle = (from guide in db.Guides
                                                   join content in db.Contents
                                                   on guide.GuideId equals content.GuideId
                                                   where guide.Url == url
                                                   where guide.LanguageId == languageId
                                                   where content.PlatformId == platformId
                                                   // where content.IsActive == true
                                                   select new GuideContent
                                                   {
                                                       GuideId = content.GuideId,
                                                       Title = guide.Title,
                                                       PlatformId = content.PlatformId,
                                                       Url = guide.Url,
                                                       Description = content.Description,
                                                       CategoryId = guide.CategoryId,
                                                       LanguageId = guide.LanguageId,
                                                       ContentId = content.ContentId,
                                                       UptadedAt = content.UpdatedAt

                                                   }
                                                ).SingleOrDefault();

                return guideContentsTitle;


            }

        }

        public List<GuideContent> GetTitleByLanguage(int languageId, int platformId)
        {
            using (TargeContext db = new TargeContext())
            {

                List<GuideContent> guideContentsTitle = (from guide in db.Guides
                                                         join content in db.Contents
                                                         on guide.GuideId equals content.GuideId
                                                         where guide.LanguageId == languageId
                                                         where content.PlatformId == platformId
                                                         // where content.IsActive == true
                                                         select new GuideContent
                                                         {
                                                             GuideId = content.GuideId,
                                                             Title = guide.Title,
                                                             PlatformId = content.PlatformId,
                                                             Url = guide.Url,
                                                             Description = content.Description,
                                                             CategoryId = guide.CategoryId,
                                                             LanguageId = guide.LanguageId,
                                                             ContentId = content.ContentId,
                                                             UptadedAt = content.UpdatedAt

                                                         }
                                                ).ToList();

                return guideContentsTitle;


            }
        }

        public string AddGuide()
        {
            return "eklendi";
        }


    }
   




}
