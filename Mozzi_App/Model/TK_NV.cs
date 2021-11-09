namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TK_NV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TK_NV()
        {
            HD = new HashSet<HD>();
        }

        [Key]
        public int ID_NV { get; set; }

        [Required]
        [StringLength(30)]
        public string Name_NV { get; set; }

        [Required]
        [StringLength(10)]
        public string SDT_NV { get; set; }

        [Required]
        [StringLength(50)]
        public string Email_NV { get; set; }

        [Required]
        [StringLength(50)]
        public string Password_NV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HD> HD { get; set; }
    }
}
