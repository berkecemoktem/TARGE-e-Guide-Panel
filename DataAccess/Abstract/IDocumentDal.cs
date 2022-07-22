using Core.DataAccess;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IDocumentDal : IEntityRepository<Document>
    {
        // Custom Operations (Only Guide Op.)
        public List<Document> GetDocumentByGuide(int guideId, int LanguageId);
    }
}
