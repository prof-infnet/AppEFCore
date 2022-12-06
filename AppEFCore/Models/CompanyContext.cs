using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AppEFCore.Models
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Fluent Api
            modelBuilder.Entity<Country>().HasKey(s => s.PId);

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasColumnName("CountryName")
                    .HasDefaultValue("USA")
                    .IsRequired();

                entity.Property(e => e.AddedOn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

            });

            modelBuilder.Entity<Country>().Ignore(e => e.Population);

            modelBuilder.Entity<TeacherStudent>()
                .HasKey(t => new { t.StudentId, t.TeacherId });

            modelBuilder.Entity<TeacherStudent>()
            .HasOne(t => t.Student)
            .WithMany(t => t.TeacherStudent)
            .HasForeignKey(t => t.StudentId);

            modelBuilder.Entity<TeacherStudent>()
            .HasOne(t => t.Teacher)
            .WithMany(t => t.TeacherStudent)
            .HasForeignKey(t => t.TeacherId);

            #endregion

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Designation)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                entity.HasOne(d => d.Department)
                .WithMany(p => p.Employee)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employee_Department");
            });










            }

    }
}
