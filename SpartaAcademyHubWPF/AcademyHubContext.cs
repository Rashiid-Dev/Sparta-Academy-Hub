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
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Connections> Connections { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Stream> Stream { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = AcademyHub; Persist Security Info = True; User ID = SA; Password = Passw0rd2018");
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

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__Accounts__C9F2845709875340");

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AcademyId).HasColumnName("AcademyID");

                entity.Property(e => e.AcademyRole)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleNames)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Academy)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AcademyId)
                    .HasConstraintName("FK__Accounts__Academ__5629CD9C");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Accounts__Course__571DF1D5");
            });

            modelBuilder.Entity<Connections>(entity =>
            {
                entity.HasKey(e => e.ConnectionId)
                    .HasName("PK__Connecti__404A64F3112BC5B3");

                entity.Property(e => e.ConnectionId)
                    .HasColumnName("ConnectionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectedTo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ConnectionsAccount)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Connectio__Accou__5AEE82B9");

                entity.HasOne(d => d.ConnectedToNavigation)
                    .WithMany(p => p.ConnectionsConnectedToNavigation)
                    .HasForeignKey(d => d.ConnectedTo)
                    .HasConstraintName("FK__Connectio__Conne__5BE2A6F2");
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

                entity.Property(e => e.StartDate).HasColumnType("date");

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
