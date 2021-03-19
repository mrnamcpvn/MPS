using Microsoft.EntityFrameworkCore;
using MPS_API.Models;

namespace MPS_API.Data
{
    public partial class RackDBContext : DbContext
    {
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }

        public RackDBContext(DbContextOptions<RackDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_90_CI_AS");

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.HasIndex(e => e.Itnbr)
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => e.VendorId)
                    .HasFillFactor((byte)80);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}