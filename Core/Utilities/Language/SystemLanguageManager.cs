using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Language
{
    public class SystemLanguageManager : ISystemLanguageService
    {
        ISystemLanguage _systemLanguage;
        public SystemLanguageManager(ISystemLanguage systemLanguage)
        {
            _systemLanguage = systemLanguage;
            
        }
      

        public string DarkModeText()
        {
            return _systemLanguage.DarkModeText;
        }

        public string DocumentText()
        {
            return _systemLanguage.DocumentText;
        }

        public string KeywordText()
        {
            return _systemLanguage.KeywordText;
        }

        public string LinkedContentText()
        {
            return _systemLanguage.LinkedContentText;
        }

        public string SearchText()
        {
            return _systemLanguage.searchText;

        }

        public string UpdatedAtText()
        {
            return _systemLanguage.UpdatedAtText;
        }

        public string UrlKeywordText()
        {
            return _systemLanguage.UrlKeywords;
        }
    }

}
