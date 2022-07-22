using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IKeywordService
    {
       List<Keyword> GetKeywordsBySearchKey(string searchKey, int languageId ); 
    }

}
