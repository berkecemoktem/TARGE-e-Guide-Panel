using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Routing", Schema = "dbo")]
    public class Routing:IEntity
    {
        public int RoutingId { get; set; }
        public int GuideId { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
    }
}
