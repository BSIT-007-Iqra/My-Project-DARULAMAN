namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Decreased
    {
        [Key]
        public int DECREASED_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(10)]
        public string AGE { get; set; }

        [Required]
        [StringLength(20)]
        public string GENDER { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_OF_DEATH { get; set; }


        [StringLength(10)]
        public string STATUS { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DATE { get; set; }
        public int FUNERAL_FID { get; set; }

        public virtual tbl_DeadRelative tbl_DeadRelative { get; set; }
    }
}
