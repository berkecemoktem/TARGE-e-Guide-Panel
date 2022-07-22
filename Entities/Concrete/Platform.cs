using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    [Table("Platform", Schema = "dbo")]

    public class Platform : IEntity
    {
        public int PlatformId { get; set; }
        public int LanguageId { get; set; }
        public int PlatformGroup { get; set; }

        public string PlatformName { get; set; }


    }
}
