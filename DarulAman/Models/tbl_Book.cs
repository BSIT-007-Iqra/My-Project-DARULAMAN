namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Book
    {
        [Key]
        public int BOOK_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string BOOK_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string BOOK_AUTHOR { get; set; }

        public string BOOK_PICTURE { get; set; }

        public string BOOK_DETAIL { get; set; }

        [Required]
        public string BOOK_PDF { get; set; }

        public int CATEGORY_FID { get; set; }

        public virtual tbl_BookCategory tbl_BookCategory { get; set; }
    }
}
