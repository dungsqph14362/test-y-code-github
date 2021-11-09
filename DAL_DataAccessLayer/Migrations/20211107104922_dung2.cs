using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class dung2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaHopDong",
                table: "PhongTro");

            migrationBuilder.DropColumn(
                name: "MaLoaiPhong",
                table: "PhongTro");

            migrationBuilder.DropColumn(
                name: "MaDichVu",
                table: "HopDongChiTiet");

            migrationBuilder.DropColumn(
                name: "MaHopDong",
                table: "HopDongChiTiet");

            migrationBuilder.DropColumn(
                name: "MaPhong",
                table: "HopDongChiTiet");

            migrationBuilder.DropColumn(
                name: "IdDichVuChiTiet",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "MaChuTro",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "MaNguoiDung",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "MaPhongTro",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "IdDichVu",
                table: "DichVuChiTiet");

            migrationBuilder.AddColumn<int>(
                name: "HopDongsMaHopDong",
                table: "PhongTro",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HopDongMaHopDong",
                table: "LoaiPhong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DichVuChiTietsId",
                table: "HopDongChiTiet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HopDongsMaHopDong",
                table: "HopDongChiTiet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChuTrosMaChuTro",
                table: "HopDong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhachHangsMaKhachHang",
                table: "HopDong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DichVusId",
                table: "DichVuChiTiet",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChucVusMaChucVu",
                table: "ChuTro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhongTro_HopDongsMaHopDong",
                table: "PhongTro",
                column: "HopDongsMaHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiPhong_HopDongMaHopDong",
                table: "LoaiPhong",
                column: "HopDongMaHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongChiTiet_DichVuChiTietsId",
                table: "HopDongChiTiet",
                column: "DichVuChiTietsId");

            migrationBuilder.CreateIndex(
                name: "IX_HopDongChiTiet_HopDongsMaHopDong",
                table: "HopDongChiTiet",
                column: "HopDongsMaHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_ChuTrosMaChuTro",
                table: "HopDong",
                column: "ChuTrosMaChuTro");

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_KhachHangsMaKhachHang",
                table: "HopDong",
                column: "KhachHangsMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DichVuChiTiet_DichVusId",
                table: "DichVuChiTiet",
                column: "DichVusId");

            migrationBuilder.CreateIndex(
                name: "IX_ChuTro_ChucVusMaChucVu",
                table: "ChuTro",
                column: "ChucVusMaChucVu");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuTro_ChucVu_ChucVusMaChucVu",
                table: "ChuTro",
                column: "ChucVusMaChucVu",
                principalTable: "ChucVu",
                principalColumn: "MaChucVu",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DichVuChiTiet_DichVu_DichVusId",
                table: "DichVuChiTiet",
                column: "DichVusId",
                principalTable: "DichVu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HopDong_ChuTro_ChuTrosMaChuTro",
                table: "HopDong",
                column: "ChuTrosMaChuTro",
                principalTable: "ChuTro",
                principalColumn: "MaChuTro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HopDong_KhachHang_KhachHangsMaKhachHang",
                table: "HopDong",
                column: "KhachHangsMaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HopDongChiTiet_DichVuChiTiet_DichVuChiTietsId",
                table: "HopDongChiTiet",
                column: "DichVuChiTietsId",
                principalTable: "DichVuChiTiet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HopDongChiTiet_HopDong_HopDongsMaHopDong",
                table: "HopDongChiTiet",
                column: "HopDongsMaHopDong",
                principalTable: "HopDong",
                principalColumn: "MaHopDong",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoaiPhong_HopDong_HopDongMaHopDong",
                table: "LoaiPhong",
                column: "HopDongMaHopDong",
                principalTable: "HopDong",
                principalColumn: "MaHopDong",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhongTro_HopDong_HopDongsMaHopDong",
                table: "PhongTro",
                column: "HopDongsMaHopDong",
                principalTable: "HopDong",
                principalColumn: "MaHopDong",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuTro_ChucVu_ChucVusMaChucVu",
                table: "ChuTro");

            migrationBuilder.DropForeignKey(
                name: "FK_DichVuChiTiet_DichVu_DichVusId",
                table: "DichVuChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HopDong_ChuTro_ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_HopDong_KhachHang_KhachHangsMaKhachHang",
                table: "HopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_HopDongChiTiet_DichVuChiTiet_DichVuChiTietsId",
                table: "HopDongChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_HopDongChiTiet_HopDong_HopDongsMaHopDong",
                table: "HopDongChiTiet");

            migrationBuilder.DropForeignKey(
                name: "FK_LoaiPhong_HopDong_HopDongMaHopDong",
                table: "LoaiPhong");

            migrationBuilder.DropForeignKey(
                name: "FK_PhongTro_HopDong_HopDongsMaHopDong",
                table: "PhongTro");

            migrationBuilder.DropIndex(
                name: "IX_PhongTro_HopDongsMaHopDong",
                table: "PhongTro");

            migrationBuilder.DropIndex(
                name: "IX_LoaiPhong_HopDongMaHopDong",
                table: "LoaiPhong");

            migrationBuilder.DropIndex(
                name: "IX_HopDongChiTiet_DichVuChiTietsId",
                table: "HopDongChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HopDongChiTiet_HopDongsMaHopDong",
                table: "HopDongChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_HopDong_ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.DropIndex(
                name: "IX_HopDong_KhachHangsMaKhachHang",
                table: "HopDong");

            migrationBuilder.DropIndex(
                name: "IX_DichVuChiTiet_DichVusId",
                table: "DichVuChiTiet");

            migrationBuilder.DropIndex(
                name: "IX_ChuTro_ChucVusMaChucVu",
                table: "ChuTro");

            migrationBuilder.DropColumn(
                name: "HopDongsMaHopDong",
                table: "PhongTro");

            migrationBuilder.DropColumn(
                name: "HopDongMaHopDong",
                table: "LoaiPhong");

            migrationBuilder.DropColumn(
                name: "DichVuChiTietsId",
                table: "HopDongChiTiet");

            migrationBuilder.DropColumn(
                name: "HopDongsMaHopDong",
                table: "HopDongChiTiet");

            migrationBuilder.DropColumn(
                name: "ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "KhachHangsMaKhachHang",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "DichVusId",
                table: "DichVuChiTiet");

            migrationBuilder.DropColumn(
                name: "ChucVusMaChucVu",
                table: "ChuTro");

            migrationBuilder.AddColumn<int>(
                name: "MaHopDong",
                table: "PhongTro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaLoaiPhong",
                table: "PhongTro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaDichVu",
                table: "HopDongChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaHopDong",
                table: "HopDongChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaPhong",
                table: "HopDongChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDichVuChiTiet",
                table: "HopDong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaChuTro",
                table: "HopDong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaNguoiDung",
                table: "HopDong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaPhongTro",
                table: "HopDong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdDichVu",
                table: "DichVuChiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
