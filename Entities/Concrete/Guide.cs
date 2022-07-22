using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Guide", Schema = "dbo")]

    public class Guide : IEntity
    {
        public int GuideId { get; set; }
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Boolean IsActive { get; set; }

    }
}
