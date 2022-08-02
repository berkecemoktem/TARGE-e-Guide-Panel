using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        public List<Document> GetDocumentByGuideId(int guideId);
        public List<Document> GetDocumentByLanguageId(int languageId);
        public List<Document> GetDocumentByGuideAndLanguage(int guideId,int languageId);
        public List<Document> GetAll();
        public string Add(Document d);
    }

}
