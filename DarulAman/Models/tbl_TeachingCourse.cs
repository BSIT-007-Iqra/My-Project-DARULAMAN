namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TeachingCourse
    {
        [Key]
        public int COURSE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string COURSE_NAME { get; set; }
    }
}
