namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Marriage
    {
        [Key]
        public int MARRIAGE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string CONTACT { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_OF_MARRIAGE { get; set; }

        [Required]
        [StringLength(50)]
        public string ORIGIN { get; set; }

        [StringLength(200)]
        public string MESSAGE { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DATE { get; set; }

        
        [StringLength(50)]
        public string STATUS { get; set; }
    }
}
