using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPlatformService
    {
        List<Platform> GetAll();
        Platform GetPlatformByName(string name);
        List<Platform> GetPlatformByLanguage(int languageId);
        string Add(Platform platform);
        List<Platform> GetById(int id);
        List<Platform> GetByLanguageId(int languageId);
        List<Platform> GetByLanguageIdAndPlatformId(int languageId, int platformId);
    }
}