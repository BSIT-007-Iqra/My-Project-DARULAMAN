namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Volunteer
    {
        [Key]
        public int VOLUNTEER_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(100)]
        public string REASON { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DATE { get; set; }

       
        [StringLength(50)]
        public string STATUS { get; set; }
    }
}
