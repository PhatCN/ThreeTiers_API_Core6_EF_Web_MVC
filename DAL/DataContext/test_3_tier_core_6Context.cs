using System;
using System.Collections.Generic;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
 

namespace DAL.DataContext
{
    public partial class test_3_tier_core_6Context : DbContext
    {
        public test_3_tier_core_6Context()
        {
        }

        public test_3_tier_core_6Context(DbContextOptions<test_3_tier_core_6Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.MaNv)
                    .HasName("PRIMARY");

                entity.ToTable("nhanvien");

                entity.HasIndex(e => e.Sdt, "SDT")
                    .IsUnique();

                entity.HasIndex(e => e.TaiKhoan, "TaiKhoan")
                    .IsUnique();

                entity.Property(e => e.MaNv)
                    .HasMaxLength(5)
                    .HasColumnName("MaNV")
                    .HasComment("Mã nhân viên");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(20)
                    .HasComment("Mật khẩu");

                entity.Property(e => e.QuyenSd)
                    .HasColumnType("int(1)")
                    .HasColumnName("QuyenSD")
                    .HasComment("Quyền sử dụng");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .HasColumnName("SDT")
                    .HasComment("Số điện thoại");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(20)
                    .HasComment("Tài khoản đăng nhập");

                entity.Property(e => e.TenNv)
                    .HasMaxLength(50)
                    .HasColumnName("TenNV")
                    .HasComment("Tên nhân viên");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
