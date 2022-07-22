using Core.Utilities.Language;
using Entities.ComplexTypes;
using Entities.Concrete;

namespace GuideUI.Models
{
    public class KeywordListData
    { 
        public List<GuideKeywords> Keywords  { get; set; }
        public List<ContentPlatform> Content { get; set; }
        public string CurrentLanguage { get; set; }
        public List<GuideContent> Titles { get; set; }
        public List<Category> Categories { get; set; }
        public string CurrentPlatform { get; set; }
        public List<GuideContent> GuideTitles { get; set; }
        public ISystemLanguageService SystemLanguage { get; set; }
        public List<Platform> Platforms { get; set; }
        public string KeywordId { get; set; }

        public List<Guide> Guides { get; set; }



    }
}
