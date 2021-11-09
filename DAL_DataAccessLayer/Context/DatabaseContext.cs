using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DAL_DataAccessLayer.Models;

#nullable disable

namespace DAL_DataAccessLayer.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChuTro> ChuTros { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<DichVuChiTiet> DichVuChiTiets { get; set; }
        public virtual DbSet<HinhAnh> HinhAnhs { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<HopDongChiTiet> HopDongChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<PhongTro> PhongTros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-8VUJD680\\SQLEXPRESS;Initial Catalog=QuanLyNhaTroTienDung;Persist Security Info=True;User ID=dungsqPh14362;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChuTro>(entity =>
            {
                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.ChuTros)
                    .HasForeignKey(d => d.MaChucVu)
                    .HasConstraintName("FK_ChuTro_ChucVu_ChucVusMaChucVu");
            });

            modelBuilder.Entity<HinhAnh>(entity =>
            {
                entity.HasOne(d => d.MaPhongTroNavigation)
                    .WithMany(p => p.HinhAnhs)
                    .HasForeignKey(d => d.MaPhongTro)
                    .HasConstraintName("FK_HinhAnh_PhongTro_PhongTrosMaPhongTro");
            });

            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.HasOne(d => d.MaChuTroNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaChuTro)
                    .HasConstraintName("FK_HopDong_ChuTro_ChuTrosMaChuTro");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK_HopDong_KhachHang_KhachHangsMaKhachHang");
            });

            modelBuilder.Entity<HopDongChiTiet>(entity =>
            {
                entity.HasOne(d => d.MaHopDongNavigation)
                    .WithMany(p => p.HopDongChiTiets)
                    .HasForeignKey(d => d.MaHopDong)
                    .HasConstraintName("FK_HopDongChiTiet_HopDong_HopDongsMaHopDong");
            });

            modelBuilder.Entity<PhongTro>(entity =>
            {
                entity.HasOne(d => d.MaHopDongNavigation)
                    .WithMany(p => p.PhongTros)
                    .HasForeignKey(d => d.MaHopDong)
                    .HasConstraintName("FK_PhongTro_HopDong_HopDongsMaHopDong");

                entity.HasOne(d => d.MaLoaiPhongNavigation)
                    .WithMany(p => p.PhongTros)
                    .HasForeignKey(d => d.MaLoaiPhong)
                    .HasConstraintName("FK_PhongTro_LoaiPhong_LoaiPhongsMaLoaiPhong");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
