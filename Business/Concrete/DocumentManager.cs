using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        IDocumentDal _documentDAL = new EfDocumentDal();

        public string Add(Document d)
        {
            try
            {
                _documentDAL.Add(d);
            }
            catch (System.Exception e)
            {
                return e.Message;
                throw;
            }
            return "ekleme basarili";
        }

        public List<Document> GetAll()
        {           
                return _documentDAL.GetList();         
        }

        public List<Document> GetDocumentByGuideAndLanguage(int guideId,int languageId)
        {
           // return _documentDAL.GetDocumentByGuide(guideId, languageId);
           return _documentDAL.GetList(p=> p.GuideId == guideId && p.LanguageId == languageId);
        }

        public List<Document> GetDocumentByGuideId(int guideId)
        {
            return _documentDAL.GetList(p=> p.GuideId == guideId);
        }

        public List<Document> GetDocumentByLanguageId(int languageId)
        {
            return _documentDAL.GetList(p => p.LanguageId == languageId);
        }
    }

}
