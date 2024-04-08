using System;
using System.Collections.Generic;
using DatabaseFirstExample.Domain.DataContext;
using DatabaseFirstExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstExample.Infrastructure.DataContext;

public partial class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=phucha.duckdns.org; Database=Sgu.DatabaseFirstExample;Trust Server Certificate=True; User ID=Sgu.Student;Password=SGUStudent@#23;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasComment("Tên khoa");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "IX_Grades_DepartmentId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DepartmentId).HasComment("Khoa");
            entity.Property(e => e.Name).HasComment("Tên lớp");

            entity.HasOne(d => d.Department).WithMany(p => p.Grades).HasForeignKey(d => d.DepartmentId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.GradeId, "IX_Students_GradeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Dob).HasComment("Ngày sinh");
            entity.Property(e => e.GradeId).HasComment("Mã lớp");
            entity.Property(e => e.Name).HasComment("Tên sinh viên");
            entity.Property(e => e.StudentId).HasComment("Mã sinh viên");

            entity.HasOne(d => d.Grade).WithMany(p => p.Students).HasForeignKey(d => d.GradeId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
