using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{

    [Table("Category", Schema = "dbo")]

    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public int QueueNo { get; set; }
        public string Title { get; set; }
    }
}
