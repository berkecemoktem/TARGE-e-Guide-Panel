using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Keyword", Schema = "dbo")]

    public class Keyword:IEntity
    {
        public int KeywordId { get; set; }
        public string Title { get; set; }
        public int LanguageId { get; set; }
    }
}
