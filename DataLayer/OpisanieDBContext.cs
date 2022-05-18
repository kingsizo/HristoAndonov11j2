using System;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLayer
{
    public partial class OpisanieDBContext : DbContext
    {
        public OpisanieDBContext()
        {
        }

        public OpisanieDBContext(DbContextOptions<OpisanieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Interesi> Interesis { get; set; }
        public virtual DbSet<Oblast> Oblasts { get; set; }
        public virtual DbSet<Potrebitel> Potrebitels { get; set; }
        public virtual DbSet<Potrebitelinteresi> Potrebitelinteresis { get; set; }
        public virtual DbSet<Priqteli> Priqtelis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=OpisanieDB;Uid=root;Pwd=94012236g;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interesi>(entity =>
            {
                entity.ToTable("interesi");

                entity.HasIndex(e => e.OblastId, "oblastId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.OblastId).HasColumnName("oblastId");

                entity.HasOne(d => d.Oblast)
                    .WithMany(p => p.Interesis)
                    .HasForeignKey(d => d.OblastId)
                    .HasConstraintName("interesi_ibfk_1");
            });

            modelBuilder.Entity<Oblast>(entity =>
            {
                entity.ToTable("oblast");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Potrebitel>(entity =>
            {
                entity.ToTable("potrebitel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("email");

                entity.Property(e => e.Familia)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("familia");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.OblastId).HasColumnName("oblastID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("username");

                entity.Property(e => e.Vuzrast).HasColumnName("vuzrast");
            });

            modelBuilder.Entity<Potrebitelinteresi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("potrebitelinteresi");

                entity.HasIndex(e => e.PotrebitelId, "potrebitelID");

                entity.Property(e => e.InteresId).HasColumnName("interesID");

                entity.Property(e => e.PotrebitelId).HasColumnName("potrebitelID");

                entity.HasOne(d => d.Potrebitel)
                    .WithMany()
                    .HasForeignKey(d => d.PotrebitelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("potrebitelinteresi_ibfk_2");

                entity.HasOne(d => d.PotrebitelNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.PotrebitelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("potrebitelinteresi_ibfk_1");
            });

            modelBuilder.Entity<Priqteli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("priqteli");

                entity.HasIndex(e => e.PotrebitelId, "potrebitelId");

                entity.Property(e => e.FriendName)
                    .HasMaxLength(20)
                    .HasColumnName("friendName");

                entity.Property(e => e.PotrebitelId).HasColumnName("potrebitelId");

                entity.HasOne(d => d.Potrebitel)
                    .WithMany()
                    .HasForeignKey(d => d.PotrebitelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("priqteli_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
