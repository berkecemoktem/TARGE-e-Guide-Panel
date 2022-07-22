using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPlatformService
    {
      Platform GetPlatformByName(string name);  
      List<Platform> GetPlatformByLanguage(int languageId);

      
     }
}