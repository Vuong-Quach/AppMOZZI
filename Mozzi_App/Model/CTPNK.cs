namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPNK")]
    public partial class CTPNK
    {
        [Key]
        public int ID_CTPNK { get; set; }

        public int ID_SP { get; set; }

        public int ID_PNK { get; set; }

        [StringLength(50)]
        public string Name_SP { get; set; }

        public double So_Luong { get; set; }

        public virtual PNK PNK { get; set; }

        public virtual SP SP { get; set; }
    }
}
