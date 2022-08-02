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

        public string Add(Platform p)
        {
            try
            {
                _platformDal.Add(p);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }

        public List<Platform> GetAll()
        {
            return _platformDal.GetList();
        }

        public List<Platform> GetById(int id)
        {
            return _platformDal.GetList(p=> p.PlatformId == id);
        }

        public List<Platform> GetByLanguageId(int languageId)
        {
            return _platformDal.GetList(p=> p.LanguageId == languageId);
        }

        public List<Platform> GetByLanguageIdAndPlatformId(int languageId, int platformId)
        {
            return _platformDal.GetList(p=> p.LanguageId == languageId && p.PlatformId == platformId);
        }

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
