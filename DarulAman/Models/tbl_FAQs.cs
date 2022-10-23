namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FAQs
    {
        [Key]
        public int FAQ_ID { get; set; }

        [StringLength(500)]
        [Required]
        public string FAQ_QUESTION { get; set; }

        [StringLength(500)]
        [Required]
        public string FAQ_ANSWER { get; set; }

    }
}
