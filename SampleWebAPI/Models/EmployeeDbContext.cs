using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SampleWebAPI.Models
{
    public partial class EmployeedbContext : DbContext
    {
        public EmployeedbContext()
        {
        }

        public EmployeedbContext(DbContextOptions<EmployeedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmpDetails> EmpDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=KEERTHIKA;Database=Employeedb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(255);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailId)
                    .IsRequired()
                    .HasColumnName("Mail-Id")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}