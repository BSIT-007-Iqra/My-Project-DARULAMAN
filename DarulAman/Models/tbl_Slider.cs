namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Slider
    {
        [Key]
        public int SLIDER_ID { get; set; }

        [StringLength(100)]
        public string SLIDER_PICTURE { get; set; }
        [StringLength(500)]

        public string SLIDER_DETAIL1 { get; set; }
        [StringLength(500)]
        public string SLIDER_DETAIL2 { get; set; }

        [StringLength(100)]
        public string REFERENCE { get; set; }
    }
}
