using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{

    [Table("GuideKeyword", Schema = "dbo")]
    public class GuideKeyword:IEntity
    {
        public int Id { get; set; }
        public int GuideId { get; set; }
        public int KeywordId { get; set; }
    }
}
