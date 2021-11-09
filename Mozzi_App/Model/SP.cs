namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SP")]
    public partial class SP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SP()
        {
            CTPNK = new HashSet<CTPNK>();
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        public int ID_SP { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_SP { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        public double So_Luong { get; set; }

        [Required]
        [StringLength(10)]
        public string Don_vi_tinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPNK> CTPNK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }
    }
}
