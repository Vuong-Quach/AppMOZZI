using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Mozzi_App.Model
{
    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<CTPNK> CTPNK { get; set; }
        public virtual DbSet<CTHD> CTHD { get; set; }
        public virtual DbSet<HD> HD { get; set; }
        public virtual DbSet<KH> KH { get; set; }
        public virtual DbSet<PNK> PNK { get; set; }
        public virtual DbSet<SP> SP { get; set; }
        public virtual DbSet<TK_NV> TK_NV { get; set; }
        public virtual DbSet<TK_QL> TK_QL { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTHD>()
                .Property(e => e.Don_vi_tinh)
                .IsFixedLength();

            modelBuilder.Entity<CTHD>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.Thanh_Tien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HD>()
                .Property(e => e.M_Discount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HD>()
                .Property(e => e.M_Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HD>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.HD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KH>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<PNK>()
                .HasMany(e => e.CTPNK)
                .WithRequired(e => e.PNK)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SP>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SP>()
                .HasMany(e => e.CTPNK)
                .WithRequired(e => e.SP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SP>()
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.SP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TK_NV>()
                .Property(e => e.SDT_NV)
                .IsFixedLength();

            modelBuilder.Entity<TK_NV>()
                .HasMany(e => e.HD)
                .WithRequired(e => e.TK_NV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TK_QL>()
                .Property(e => e.SDT_QL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TK_QL>()
                .HasMany(e => e.HD)
                .WithRequired(e => e.TK_QL)
                .HasForeignKey(e => e.ID_NV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TK_QL>()
                .HasMany(e => e.PNK)
                .WithRequired(e => e.TK_QL)
                .WillCascadeOnDelete(false);
        }
    }
}
