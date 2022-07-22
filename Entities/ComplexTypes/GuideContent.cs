using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexTypes
{
    public class GuideContent:IEntity
    {
        public int GuideId { get; set; }
        public int ContentId { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int PlatformId { get; set; }
        public DateTime UptadedAt { get; set; }
        //public Boolean IsActive { get; set; }
        public string Url { get; set; }



    }
}
