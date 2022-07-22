using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Language
{
    public class TurkishLanguage : ISystemLanguage
    {
      

        public string DocumentText { get; set; } = "İlgili Dökümantasyon";
        public string LinkedContentText { get; set; } = "Bağlantılı İçerikler";
        public string searchText { get; set; } = "Arayınız";
        public string DarkModeText { get; set; } = "Koyu Mod";
        public string KeywordText { get; set; } = "Anahtar Kelimeler:";
        public string UrlKeywords { get; set; } = "anahtarlar";
        public string UpdatedAtText { get; set; } = "Son güncelleme zamanı:";

    }
}
