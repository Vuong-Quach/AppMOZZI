namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HD")]
    public partial class HD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HD()
        {
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        public int ID_HD { get; set; }

        public DateTime Date_HD { get; set; }

        public int ID_NV { get; set; }

        public int? ID_KH { get; set; }

        [Column(TypeName = "money")]
        public decimal? M_Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal M_Total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }

        public virtual KH KH { get; set; }

        public virtual TK_NV TK_NV { get; set; }

        public virtual TK_QL TK_QL { get; set; }
    }
}
