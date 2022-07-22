using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContentDal : EfEntityRepositoryBase<Content, TargeContext>, IContentDal // TargeContexte bağımlı bir class oldu.. (değiştirilmesi gerek)
    {
        public List<GuideContent> guideContentsByLanguageAndPlatform(int languageId, int platformId)
        {
            using (TargeContext db = new TargeContext())
            {
                List<GuideContent> guideContents = (from content in db.Contents
                                                    join guide in db.Guides
                                                    on content.GuideId equals guide.GuideId
                                                    where guide.LanguageId == languageId
                                                    where content.PlatformId == platformId
                                                    select new GuideContent
                                                    {
                                                        ContentId = content.ContentId,
                                                        Description = content.Description,
                                                        GuideId = content.GuideId,
                                                        LanguageId = guide.LanguageId,
                                                        Title = guide.Title,
                                                        UptadedAt = Convert.ToDateTime(content.UpdatedAt), 
                                                        PlatformId = content.PlatformId,
                                                        Url=guide.Url,
                                                        CategoryId=guide.CategoryId
                                                    }
                                                    ).ToList();
                return guideContents;
            }

        }


        public GuideContent GetGuideTitleByUrl(int languageId, int platformId, string url)
        {
            using (TargeContext db = new TargeContext())
            {

                GuideContent guideContentsTitle = (from content in db.Contents
                                              join guide in db.Guides
                                              on content.GuideId equals guide.GuideId
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
                                                  CategoryId=guide.CategoryId,
                                                  LanguageId=guide.LanguageId,
                                                  ContentId=content.ContentId,
                                                  UptadedAt= content.UpdatedAt
                                                  

                                              }
                                                ).SingleOrDefault();

                return guideContentsTitle;


            }

        }

        public List<GuideContent> GetTitlesByLanguage(int languageId, int platformId)
        {
            using (TargeContext db = new TargeContext())
            {

                List<GuideContent> Titles = (from content in db.Contents
                                             join guide in db.Guides
                                             on content.GuideId equals guide.GuideId
                                             where guide.LanguageId == languageId
                                             where content.PlatformId == platformId
                                             select new GuideContent
                                             {
                                                 ContentId = content.ContentId,
                                                 GuideId = content.GuideId,
                                                 CategoryId = guide.CategoryId,
                                                 Title = guide.Title,
                                                 Url = guide.Url,
                                                 
                                                
                                             }
                                                 ).ToList();

                return Titles;


            }

        }

        public List<GuideContent> GetGuideContentsByGuideId(List<GuideKeywords> guideId)
        {
            using (TargeContext db = new TargeContext())
            {

                //List<GuideContent> guideContents = (from gk in db.GuideKeywords
                //                                    join guide in db.Guides
                //                                    on gk.GuideId equals guide.GuideId
                //                                    join content in db.Contents
                //                                    on gk.GuideId equals content.GuideId
                //                                    where guideId.Contains(gk.GuideId)
                //                                    select new GuideContent
                //                                    {
                //                                        GuideId = content.GuideId,
                //                                        Title = content.Title,
                //                                        PlatformId = content.PlatformId,
                //                                        Url = content.Url,
                //                                        Description = content.Description

                //                                    }
                //                                ).ToList();

                return null;


            }
        }

        public List<ContentPlatform> GetByGuides(List<GuideKeyword> guidesId, int languageId)
        {
            using (TargeContext db = new TargeContext())
            {
                List<ContentPlatform> guideContents = (from content in db.Contents
                                                       join guide in db.Guides
                                                   on content.GuideId equals guide.GuideId
                                                       join platform in db.Platforms
                                                    on content.PlatformId equals platform.PlatformId
                                                       //where platform.LanguageId == languageId 
                                                       select new ContentPlatform
                                                       {
                                                           ContentId = content.ContentId,
                                                           GuideId = guide.GuideId,
                                                           LanguageId = guide.LanguageId,
                                                           PlatformName = platform.PlatformName,
                                                           Title = guide.Title,
                                                           PlatformId = content.PlatformId,
                                                           Url = guide.Url,
                                                           Description = content.Description,
                                                           UpdatedAt = content.UpdatedAt,

                                                       }
                                                ).AsEnumerable().Where(x => guidesId.Any(v => v.GuideId == x.GuideId)).ToList();
                return guideContents;
                /*db.Contents.AsEnumerable().Where(x => guidesId.Any(v=> v.GuideId == x.GuideId)).ToList();*/
            }
        }
    }

}
