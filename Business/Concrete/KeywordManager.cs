using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class KeywordManager : IKeywordService
    {

        IKeywordDal _keywordDal = new EfKeywordDal();

        public string Add(Keyword k)
        {
            try
            {
                 _keywordDal.Add(k);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "ok";
        }

        public List<Keyword> GetAll()
        {
            return _keywordDal.GetList();
        }

        public List<Keyword> GetById(int id)
        {
            return _keywordDal.GetList(p=> p.KeywordId == id);
        }

        public List<Keyword> GetByLanguageId(int languageId)
        {
            //Console.WriteLine("OK");
            return _keywordDal.GetList(p=> p.LanguageId == languageId);
        }

        public List<Keyword> GetKeywordsBySearchKey(string searchKey, int languageId)
        {
            return null;
        }
    }

}
