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
        public List<Document> GetDocumentByGuide(int guideId,int languageId)
        {
            return _documentDAL.GetDocumentByGuide(guideId, languageId);
        }
    }

}
