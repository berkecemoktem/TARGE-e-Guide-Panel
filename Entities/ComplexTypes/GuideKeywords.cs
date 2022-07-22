using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexTypes
{
    public class GuideKeywords : IEntity
    {
        public int GuideId{ get; set; }
        public int KeywordId{ get; set; }
        public int CategoryId{ get; set; }
        public int LanguageId { get; set; }
        public string Title  { get; set; }
        public Boolean IsActive{ get; set; }
    }
}
