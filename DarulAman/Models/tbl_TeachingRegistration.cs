namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TeachingRegistration
    {
        [Key]
        public int TEACHING_ID { get; set; }

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

        [Required]
        [StringLength(50)]
        public string GENDER { get; set; }

        [Required]
        [StringLength(50)]
        public string ORIGIN { get; set; }

        [Required]
        [StringLength(200)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(100)]
        public string GUARDIAN { get; set; }

        [Required]
        [StringLength(50)]
        public string COURSE { get; set; }

        [StringLength(200)]
        public string MESSAGE { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DATE { get; set; }
    }
}
