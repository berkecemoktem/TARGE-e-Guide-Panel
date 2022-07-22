using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class KeywordManager : IKeywordService
    {

        IKeywordDal _keywordDal = new EfKeywordDal();
        public List<Keyword> GetKeywordsBySearchKey(string searchKey, int languageId)
        {
            return null;
        }
    }

}
