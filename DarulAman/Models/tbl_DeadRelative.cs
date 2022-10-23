namespace DarulAman.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DeadRelative
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DeadRelative()
        {
            tbl_Decreased = new HashSet<tbl_Decreased>();
        }

        [Key]
        public int FUNERAL_ID { get; set; }

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

        [StringLength(50)]
        public string RELATION_WITH_DEAD { get; set; }

        [Required]
        [StringLength(50)]
        public string ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE_OF_FUNERAL { get; set; }

        [Required]
        [StringLength(50)]
        public string ORIGIN { get; set; }

        [StringLength(200)]
        public string MESSAGE { get; set; }

       
        [StringLength(10)]
        public string CONDITION { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DATE { get; set; }

      

    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Decreased> tbl_Decreased { get; set; }
    }
}
