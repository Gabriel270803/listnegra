using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace backend.Models
{
    public partial class infob08Context : DbContext
    {
        public infob08Context()
        {
        }

        public infob08Context(DbContextOptions<infob08Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TbListaNegra> TbListaNegra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=1234;database=infob08", x => x.ServerVersion("8.0.18-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbListaNegra>(entity =>
            {
                entity.HasKey(e => e.IdListaNegra)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsMotivo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmPessoa)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
