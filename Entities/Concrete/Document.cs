using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Document", Schema = "dbo")]
    public class Document:IEntity
    {
        public int DocumentId { get; set; }
        public int GuideId { get; set; }
        public int LanguageId { get; set; }
        public string DocumentName { get; set; }
        public string Description { get; set; }
    }
}
