namespace Mozzi_App.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        public int ID_CTHD { get; set; }

        public int ID_HD { get; set; }

        public int ID_SP { get; set; }

        [Required]
        [StringLength(50)]
        public string Name_SP { get; set; }

        public double So_Luong { get; set; }

        [Required]
        [StringLength(10)]
        public string Don_vi_tinh { get; set; }

        [Column(TypeName = "money")]
        public decimal Gia { get; set; }

        [Column(TypeName = "money")]
        public decimal Thanh_Tien { get; set; }

        public virtual HD HD { get; set; }

        public virtual SP SP { get; set; }
    }
}
