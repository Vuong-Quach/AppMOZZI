namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TK_QL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TK_QL()
        {
            HD = new HashSet<HD>();
            PNK = new HashSet<PNK>();
        }

        [Key]
        public int ID_QL { get; set; }

        [Required]
        [StringLength(30)]
        public string Name_QL { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT_QL { get; set; }

        [Required]
        [StringLength(50)]
        public string Email_QL { get; set; }

        [Required]
        [StringLength(50)]
        public string Password_QL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HD> HD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PNK> PNK { get; set; }
    }
}
