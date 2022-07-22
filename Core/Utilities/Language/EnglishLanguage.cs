using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Language
{
    public class EnglishLanguage : ISystemLanguage
    {
      
        public string DocumentText { get; set; } = "Related Documentation";
        public string LinkedContentText { get; set; } = "Linked Content";
        public string searchText { get; set; } = "Search";
        public string DarkModeText { get; set; } = "Dark Mode";
        public string KeywordText { get; set; } = "Keywords:";
        public string UrlKeywords { get; set; } = "keywords";
        public string UpdatedAtText { get; set; } = "Last update time:";
    }
}
