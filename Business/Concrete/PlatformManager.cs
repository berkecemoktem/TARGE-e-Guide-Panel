using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PlatformManager : IPlatformService
    {
        IPlatformDal _platformDal = new EfPlatformDal();

        public List<Platform> GetPlatformByLanguage(int languageId)
        {
            return _platformDal.GetList(p => p.LanguageId == languageId);
        }

        public Platform GetPlatformByName(string name)
        {
            return _platformDal.Get(p => p.PlatformName == name);
        }
        
       

    }

}
