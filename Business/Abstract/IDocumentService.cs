using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        public List<Document> GetDocumentByGuide(int guideId,int languageId);
    }

}
