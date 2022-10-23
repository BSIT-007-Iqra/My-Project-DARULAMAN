namespace DarulAman.Models
{
    using System;
    using System.Web;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Team
    {
        [Key]
        public int TEAM_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FIRST_NAME { get; set; }

        [Required]
        [StringLength(50)]
        public string LAST_NAME { get; set; }
        
      
        [StringLength(100)]
        public string PICTURE { get; set; }


       
        [StringLength(50)]
        public string GENDER { get; set; }

       
        [StringLength(50)]
        public string EMAIL { get; set; }

    
        [StringLength(50)]
        public string CONTACT { get; set; }

        
        [StringLength(50)]
        public string ID { get; set; }

       
        [StringLength(50)]
        public string ORIGIN { get; set; }

        
        [StringLength(200)]
        public string ADDRESS { get; set; }

       
        [StringLength(100)]
        public string RESPONSIBILITIES { get; set; } 

        [StringLength(50)]
        public string PROFESSION { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? DATE_OF_JOINING { get; set; }

      
        [StringLength(100)]
        public string LANGUAGES { get; set; }
    }
}
