namespace DarulAman.Models
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Event
    {
        [Key]
        public int EVENT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string EVENT_NAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime EVENT_DATE { get; set; }

       
        [StringLength(50)]
        public string EVENT_DESCRIPTION { get; set; }

        
        [StringLength(100)]
        public string EVENT_PICTURE { get; set; }

        public DateTime? TIME_TO { get; set; }

        public DateTime? TIME_FROM { get; set; }

        [StringLength(200)]
        public string ADDRESS { get; set; }
    }
}
