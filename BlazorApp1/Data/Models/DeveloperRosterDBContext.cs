using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorApp1.Data.Models
{
    public partial class DeveloperRosterDBContext : DbContext
    {
        public DeveloperRosterDBContext()
        {
        }

        public DeveloperRosterDBContext(DbContextOptions<DeveloperRosterDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NewHire> NewHires { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=Database=DeveloperRosterDB; Trusted_Connection=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NewHire>(entity =>
            {
                entity.ToTable("NewHire");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.ImageFileName).IsUnicode(false);

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.IsCurrent)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
