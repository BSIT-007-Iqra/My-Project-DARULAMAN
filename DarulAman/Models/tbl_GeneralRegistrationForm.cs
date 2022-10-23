namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_GeneralRegistrationForm
    {
        [Key]
        public int GENERAL_ID { get; set; }

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
        public string PROFESSION { get; set; }

        [Required]
        [StringLength(50)]
        public string GENDER { get; set; }

        [Required]
        [StringLength(50)]
        public string COUNTRY { get; set; }

        [Required]
        [StringLength(50)]
        public string CITY { get; set; }

        [Required]
        [StringLength(200)]
        public string ADDRESS { get; set; }

        [StringLength(200)]
        public string MESSAGE { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DATE { get; set; }
    }
}
