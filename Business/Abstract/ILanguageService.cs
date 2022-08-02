using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILanguageService
    {
         List<Language>GetLanguages ();
         Language GetLanguageByShortTitle(string sTitle);
        public string Add(Language lan);
        object GetById(int id);
    }

}
