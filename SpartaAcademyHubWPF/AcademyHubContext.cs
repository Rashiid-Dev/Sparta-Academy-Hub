using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpartaAcademyHubWPF
{
    public partial class AcademyHubContext : DbContext
    {
        public AcademyHubContext()
        {
        }

        public AcademyHubContext(DbContextOptions<AcademyHubContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Academies> Academies { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Stream> Stream { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog = AcademyHub; Persist Security Info = True; User ID = SA; Password = Passw0rd2018");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Academies>(entity =>
            {
                entity.HasKey(e => e.AcademyId)
                    .HasName("PK__Academie__E75506D957262104");

                entity.Property(e => e.AcademyId).HasColumnName("AcademyID");

                entity.Property(e => e.Academyname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Academies)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Academies__Locat__44FF419A");
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK__Courses__C92D7187DF444CEB");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.AcademyId).HasColumnName("AcademyID");

                entity.Property(e => e.Coursename)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StreamId).HasColumnName("StreamID");

                entity.HasOne(d => d.Academy)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.AcademyId)
                    .HasConstraintName("FK__Courses__Academy__4CA06362");

                entity.HasOne(d => d.Stream)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.StreamId)
                    .HasConstraintName("FK__Courses__StreamI__4BAC3F29");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Location__E7FEA4776C4B82FF");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stream>(entity =>
            {
                entity.Property(e => e.StreamId).HasColumnName("StreamID");

                entity.Property(e => e.Streamname)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
