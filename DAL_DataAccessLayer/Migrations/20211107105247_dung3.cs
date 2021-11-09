using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class dung3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoaiPhong_HopDong_HopDongMaHopDong",
                table: "LoaiPhong");

            migrationBuilder.DropIndex(
                name: "IX_LoaiPhong_HopDongMaHopDong",
                table: "LoaiPhong");

            migrationBuilder.DropColumn(
                name: "HopDongMaHopDong",
                table: "LoaiPhong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HopDongMaHopDong",
                table: "LoaiPhong",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoaiPhong_HopDongMaHopDong",
                table: "LoaiPhong",
                column: "HopDongMaHopDong");

            migrationBuilder.AddForeignKey(
                name: "FK_LoaiPhong_HopDong_HopDongMaHopDong",
                table: "LoaiPhong",
                column: "HopDongMaHopDong",
                principalTable: "HopDong",
                principalColumn: "MaHopDong",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
