namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Institute
    {
        [Key]
        public int INSTITUTE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string INSTITUTE_EMAIL { get; set; }

        [Required]
        [StringLength(50)]
        public string INSTITUTE_CONTACT { get; set; }
    }
}
