namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KH")]
    public partial class KH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KH()
        {
            HD = new HashSet<HD>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_KH { get; set; }

        [Required]
        [StringLength(30)]
        public string Name_KH { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public int? Points { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HD> HD { get; set; }
    }
}
