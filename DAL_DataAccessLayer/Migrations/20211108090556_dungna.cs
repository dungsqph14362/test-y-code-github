using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class dungna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HopDong_ChuTro_ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_HopDong_KhachHang_KhachHangsMaKhachHang",
                table: "HopDong");

            migrationBuilder.DropIndex(
                name: "IX_HopDong_ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.RenameColumn(
                name: "LoaiPhongsMaLoaiPhong",
                table: "PhongTro",
                newName: "MaLoaiPhong");

            migrationBuilder.RenameColumn(
                name: "HopDongsMaHopDong",
                table: "PhongTro",
                newName: "MaHopDong");

            migrationBuilder.RenameColumn(
                name: "HopDongsMaHopDong",
                table: "HopDongChiTiet",
                newName: "MaHopDong");

            migrationBuilder.RenameColumn(
                name: "KhachHangsMaKhachHang",
                table: "HopDong",
                newName: "MaChuTro");

            migrationBuilder.RenameIndex(
                name: "IX_HopDong_KhachHangsMaKhachHang",
                table: "HopDong",
                newName: "IX_HopDong_ChuTrosMaChuTro");

            migrationBuilder.RenameColumn(
                name: "PhongTrosMaPhongTro",
                table: "HinhAnh",
                newName: "MaPhongTro");

            migrationBuilder.RenameColumn(
                name: "ChucVusMaChucVu",
                table: "ChuTro",
                newName: "MaChucVu");

            migrationBuilder.AlterDatabase(
                collation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AddColumn<int>(
                name: "MaKhachHang",
                table: "HopDong",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "TenChucVu",
                table: "ChucVu",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_KhachHangsMaKhachHang",
                table: "HopDong",
                column: "MaKhachHang");

            migrationBuilder.AddForeignKey(
                name: "FK_HopDong_ChuTro_ChuTrosMaChuTro",
                table: "HopDong",
                column: "MaChuTro",
                principalTable: "ChuTro",
                principalColumn: "MaChuTro",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HopDong_KhachHang_KhachHangsMaKhachHang",
                table: "HopDong",
                column: "MaKhachHang",
                principalTable: "KhachHang",
                principalColumn: "MaKhachHang",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HopDong_ChuTro_ChuTrosMaChuTro",
                table: "HopDong");

            migrationBuilder.DropForeignKey(
                name: "FK_HopDong_KhachHang_KhachHangsMaKhachHang",
                table: "HopDong");

            migrationBuilder.DropIndex(
                name: "IX_HopDong_KhachHangsMaKhachHang",
                table: "HopDong");

            migrationBuilder.DropColumn(
                name: "MaKhachHang",
                table: "HopDong");

            migrationBuilder.RenameColumn(
                name: "MaLoaiPhong",
                table: "PhongTro",
                newName: "LoaiPhongsMaLoaiPhong");

            migrationBuilder.RenameColumn(
                name: "MaHopDong",
                table: "PhongTro",
                newName: "HopDongsMaHopDong");

            migrationBuilder.RenameColumn(
                name: "MaHopDong",
                table: "HopDongChiTiet",
                newName: "HopDongsMaHopDong");

            migrationBuilder.RenameColumn(
                name: "MaChuTro",
                table: "HopDong",
                newName: "KhachHangsMaKhachHang");

            migrationBuilder.RenameIndex(
                name: "IX_HopDong_ChuTrosMaChuTro",
                table: "HopDong",
                newName: "IX_HopDong_KhachHangsMaKhachHang");

            migrationBuilder.RenameColumn(
                name: "MaPhongTro",
                table: "HinhAnh",
                newName: "PhongTrosMaPhongTro");

            migrationBuilder.RenameColumn(
                name: "MaChucVu",
                table: "ChuTro",
                newName: "ChucVusMaChucVu");

            migrationBuilder.AlterDatabase(
                oldCollation: "SQL_Latin1_General_CP1_CI_AS");

            migrationBuilder.AddColumn<int>(
                name: "ChuTrosMaChuTro",
                table: "HopDong",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TenChucVu",
                table: "ChucVu",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_HopDong_ChuTrosMaChuTro",
                table: "HopDong",
                column: "ChuTrosMaChuTro");

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
        }
    }
}
