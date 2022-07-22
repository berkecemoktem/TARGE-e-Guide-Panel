using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{

    [Table("Content", Schema = "dbo")]

    public class Content:IEntity
    {
        public int ContentId { get; set; }
        public int GuideId { get; set; }
        //public string Title { get; set; }
        public string Description { get; set; }
        //public string Platform { get; set; }
        public int  PlatformId { get; set; }

        public DateTime UpdatedAt { get; set; }

        //public string Url { get; set; }   
       // public Boolean IsActive { get; set; }
    }
}
