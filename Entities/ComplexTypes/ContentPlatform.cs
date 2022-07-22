using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexTypes
{
    public class ContentPlatform : IEntity
    {
        public int  ContentId { get; set; }
        public int GuideId { get; set; }
        public int PlatformId { get; set; }
        public int LanguageId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PlatformName { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
