﻿// <auto-generated />
using System;
using DAL_DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL_DataAccessLayer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL_DataAccessLayer.Models.ChuTro", b =>
                {
                    b.Property<int>("MaChuTro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChucVu")
                        .HasColumnType("int");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MaChucVu")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NamSinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sdt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SDT");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaChuTro");

                    b.HasIndex(new[] { "MaChucVu" }, "IX_ChuTro_ChucVusMaChucVu");

                    b.ToTable("ChuTro");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.ChucVu", b =>
                {
                    b.Property<int>("MaChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TenChucVu")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("MaChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.DichVu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LoaiDichVu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenDichVu")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DichVu");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.DichVuChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChiSoCu")
                        .HasColumnType("int");

                    b.Property<int>("ChiSoMoi")
                        .HasColumnType("int");

                    b.Property<int?>("DichVusId")
                        .HasColumnType("int");

                    b.Property<string>("DonGia")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DichVusId" }, "IX_DichVuChiTiet_DichVusId");

                    b.ToTable("DichVuChiTiet");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HinhAnh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HinhAnhPhong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MaPhongTro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "MaPhongTro" }, "IX_HinhAnh_PhongTrosMaPhongTro");

                    b.ToTable("HinhAnh");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HopDong", b =>
                {
                    b.Property<int>("MaHopDong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MaChuTro")
                        .HasColumnType("int");

                    b.Property<int>("MaKhachHang")
                        .HasColumnType("int");

                    b.Property<string>("TongTien")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaHopDong");

                    b.HasIndex(new[] { "MaChuTro" }, "IX_HopDong_ChuTrosMaChuTro");

                    b.HasIndex(new[] { "MaKhachHang" }, "IX_HopDong_KhachHangsMaKhachHang");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HopDongChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DichVuChiTietsId")
                        .HasColumnType("int");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("MaHopDong")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayXuat")
                        .HasColumnType("datetime2");

                    b.Property<string>("TienDien")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TienMang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TienNuoc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TienPhong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TienVeSinh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DichVuChiTietsId" }, "IX_HopDongChiTiet_DichVuChiTietsId");

                    b.HasIndex(new[] { "MaHopDong" }, "IX_HopDongChiTiet_HopDongsMaHopDong");

                    b.ToTable("HopDongChiTiet");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cccd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CCCD");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("MaPhongTro")
                        .HasColumnType("int");

                    b.Property<string>("QueQuan")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenKhachHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TienCoc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.LoaiPhong", b =>
                {
                    b.Property<int>("MaLoaiPhong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoaiPhong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaLoaiPhong");

                    b.ToTable("LoaiPhong");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.PhongTro", b =>
                {
                    b.Property<int>("MaPhongTro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DienTich")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GiaPhong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HinhAnh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MaHopDong")
                        .HasColumnType("int");

                    b.Property<int?>("MaLoaiPhong")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaPhongTro");

                    b.HasIndex(new[] { "MaHopDong" }, "IX_PhongTro_HopDongsMaHopDong");

                    b.HasIndex(new[] { "MaLoaiPhong" }, "IX_PhongTro_LoaiPhongsMaLoaiPhong");

                    b.ToTable("PhongTro");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.ChuTro", b =>
                {
                    b.HasOne("DAL_DataAccessLayer.Models.ChucVu", "MaChucVuNavigation")
                        .WithMany("ChuTros")
                        .HasForeignKey("MaChucVu")
                        .HasConstraintName("FK_ChuTro_ChucVu_ChucVusMaChucVu");

                    b.Navigation("MaChucVuNavigation");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.DichVuChiTiet", b =>
                {
                    b.HasOne("DAL_DataAccessLayer.Models.DichVu", "DichVus")
                        .WithMany("DichVuChiTiets")
                        .HasForeignKey("DichVusId");

                    b.Navigation("DichVus");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HinhAnh", b =>
                {
                    b.HasOne("DAL_DataAccessLayer.Models.PhongTro", "MaPhongTroNavigation")
                        .WithMany("HinhAnhs")
                        .HasForeignKey("MaPhongTro")
                        .HasConstraintName("FK_HinhAnh_PhongTro_PhongTrosMaPhongTro");

                    b.Navigation("MaPhongTroNavigation");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HopDong", b =>
                {
                    b.HasOne("DAL_DataAccessLayer.Models.ChuTro", "MaChuTroNavigation")
                        .WithMany("HopDongs")
                        .HasForeignKey("MaChuTro")
                        .HasConstraintName("FK_HopDong_ChuTro_ChuTrosMaChuTro");

                    b.HasOne("DAL_DataAccessLayer.Models.KhachHang", "MaKhachHangNavigation")
                        .WithMany("HopDongs")
                        .HasForeignKey("MaKhachHang")
                        .HasConstraintName("FK_HopDong_KhachHang_KhachHangsMaKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaChuTroNavigation");

                    b.Navigation("MaKhachHangNavigation");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HopDongChiTiet", b =>
                {
                    b.HasOne("DAL_DataAccessLayer.Models.DichVuChiTiet", "DichVuChiTiets")
                        .WithMany("HopDongChiTiets")
                        .HasForeignKey("DichVuChiTietsId");

                    b.HasOne("DAL_DataAccessLayer.Models.HopDong", "MaHopDongNavigation")
                        .WithMany("HopDongChiTiets")
                        .HasForeignKey("MaHopDong")
                        .HasConstraintName("FK_HopDongChiTiet_HopDong_HopDongsMaHopDong");

                    b.Navigation("DichVuChiTiets");

                    b.Navigation("MaHopDongNavigation");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.PhongTro", b =>
                {
                    b.HasOne("DAL_DataAccessLayer.Models.HopDong", "MaHopDongNavigation")
                        .WithMany("PhongTros")
                        .HasForeignKey("MaHopDong")
                        .HasConstraintName("FK_PhongTro_HopDong_HopDongsMaHopDong");

                    b.HasOne("DAL_DataAccessLayer.Models.LoaiPhong", "MaLoaiPhongNavigation")
                        .WithMany("PhongTros")
                        .HasForeignKey("MaLoaiPhong")
                        .HasConstraintName("FK_PhongTro_LoaiPhong_LoaiPhongsMaLoaiPhong");

                    b.Navigation("MaHopDongNavigation");

                    b.Navigation("MaLoaiPhongNavigation");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.ChuTro", b =>
                {
                    b.Navigation("HopDongs");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.ChucVu", b =>
                {
                    b.Navigation("ChuTros");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.DichVu", b =>
                {
                    b.Navigation("DichVuChiTiets");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.DichVuChiTiet", b =>
                {
                    b.Navigation("HopDongChiTiets");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.HopDong", b =>
                {
                    b.Navigation("HopDongChiTiets");

                    b.Navigation("PhongTros");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.KhachHang", b =>
                {
                    b.Navigation("HopDongs");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.LoaiPhong", b =>
                {
                    b.Navigation("PhongTros");
                });

            modelBuilder.Entity("DAL_DataAccessLayer.Models.PhongTro", b =>
                {
                    b.Navigation("HinhAnhs");
                });
#pragma warning restore 612, 618
        }
    }
}
