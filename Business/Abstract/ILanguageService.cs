using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ILanguageService
    {
         List<Language>GetLanguages ();
         Language GetLanguageByShortTitle(string sTitle);
    }

}
