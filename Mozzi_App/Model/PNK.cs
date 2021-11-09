namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PNK")]
    public partial class PNK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PNK()
        {
            CTPNK = new HashSet<CTPNK>();
        }

        [Key]
        public int ID_PNK { get; set; }

        public DateTime Date_PNK { get; set; }

        public int ID_QL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPNK> CTPNK { get; set; }

        public virtual TK_QL TK_QL { get; set; }
    }
}
