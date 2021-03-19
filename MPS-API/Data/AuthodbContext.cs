using Microsoft.EntityFrameworkCore;
using MPS_API.Models;

namespace MPS_API.Data
{
    public partial class AuthodbContext : DbContext
    {
        public virtual DbSet<UserAcc> UserAcc { get; set; }
        public virtual DbSet<UserWebAutho> UserWebAutho { get; set; }

        public AuthodbContext(DbContextOptions<AuthodbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<UserAcc>(entity =>
            {
                entity.HasKey(e => new { e.manuf, e.account });

                entity.Property(e => e.manuf)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.account)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.dept)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.email).IsUnicode(false);

                entity.Property(e => e.empno)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.id).ValueGeneratedOnAdd();

                entity.Property(e => e.image).IsUnicode(false);

                entity.Property(e => e.intime)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.passw)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.sex)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.token).IsUnicode(false);

                entity.Property(e => e.uptime)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.vname)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<UserWebAutho>(entity =>
            {
                entity.HasKey(e => new { e.account, e.AuthoWeb });

                entity.Property(e => e.account)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.AuthoWeb)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AuthoIOP)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.inusr)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.upusr)
                    .IsUnicode(false)
                    .IsFixedLength(true)
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}