namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Admin
    {
        [Key]
        public int ADMIN_ID { get; set; }

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
        public string CONTACT { get; set; }

        [Required]
        [StringLength(50)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(200)]
        public string ADDRESS { get; set; } 

        [StringLength(10)]
        public string STATUS{ get; set; }

        public int ACCESS_LEVEL_FID { get; set; }

        public virtual tbl_AccessLevel tbl_AccessLevel { get; set; }
    }
}
