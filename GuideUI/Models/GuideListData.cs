using Core.Utilities.Language;
using Entities.ComplexTypes;
using Entities.Concrete;
using GuideUI.Entities;

namespace GuideUI.Models
{
    public class GuideListData
    {
        public List<Category>Categories { get; set; }

        public List<GuideContent>Titles { get; set; }

        public List<Document>Documents { get; set; }

        public List<Routing>Routings { get; set; }
         
        public List<GuideContent>Contents { get; set; }

        public GuideContent Content { get; set; }
        public string CurrentPlatform { get; set; }

        public Category CurrentCategory { get; set; }   

        public List<Platform> OtherPlatforms { get; set; } 
        public List<Platforms> Platforms{ get; set; }

        public string CurrentLanguage { get; set; } 

        public List<GuideKeywords> Keywords { get; set; }

        public ISystemLanguageService SystemLanguage { get; set; }



    }
}
