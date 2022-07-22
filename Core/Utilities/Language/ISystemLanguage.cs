using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Language
{
    public interface ISystemLanguage
    {
        public  string DocumentText { get; set; } 
        public  string LinkedContentText { get; set; }
        public  string searchText { get; set; } 
        public  string DarkModeText { get; set; }
        public  string KeywordText { get; set; }    
        public string UrlKeywords { get; set; }

        public string UpdatedAtText { get; set; }


    }
}
