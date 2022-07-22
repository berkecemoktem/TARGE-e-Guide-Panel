using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDocumentDal : EfEntityRepositoryBase<Document, TargeContext>, IDocumentDal
    {
        public List<Document> GetDocumentByGuide(int guideId,int LanguageId)
        {
            using(TargeContext context = new TargeContext())
            {
                return context.Documents.Where(p => p.LanguageId == LanguageId).Where(g => g.GuideId == guideId).ToList(); 
            }

        }
    }

}
