﻿using Business.Abstract;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{   
    public class LanguageManager:ILanguageService
    {
        private ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal) => _languageDal = languageDal;

        public string Add(Language lan)
        {
            try
            {
                _languageDal.Add(lan);
            }
            catch (System.Exception e)
            {
                return e.Message;
                throw;
            }
            return "ekleme basarili";
        }

        public object GetById(int id)
        {
            return _languageDal.GetList(p=> p.LanguageId == id);
        }

        public Language GetLanguageByShortTitle(string sTitle)
        {
            return _languageDal.Get(p => p.ShortTitle == sTitle);
        }

        public List<Language> GetLanguages() => _languageDal.GetList();

    }

}
