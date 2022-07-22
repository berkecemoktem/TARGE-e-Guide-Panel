using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Language", Schema = "dbo")]
    public class Language:IEntity
    {
        public int LanguageId { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }

    }
}
