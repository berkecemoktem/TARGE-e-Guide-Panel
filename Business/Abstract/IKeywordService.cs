using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IKeywordService
    {
        List<Keyword> GetKeywordsBySearchKey(string searchKey, int languageId );
        public string Add(Keyword k);
        public List<Keyword> GetAll();
        List<Keyword>GetById(int id);
        List<Keyword> GetByLanguageId(int languageId);
    }

}
