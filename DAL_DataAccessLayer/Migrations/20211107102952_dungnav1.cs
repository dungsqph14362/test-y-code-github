using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_DataAccessLayer.Migrations
{
    public partial class dungnav1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LoaiPhongsMaLoaiPhong",
                table: "PhongTro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhongTro_LoaiPhongsMaLoaiPhong",
                table: "PhongTro",
                column: "LoaiPhongsMaLoaiPhong");

            migrationBuilder.AddForeignKey(
                name: "FK_PhongTro_LoaiPhong_LoaiPhongsMaLoaiPhong",
                table: "PhongTro",
                column: "LoaiPhongsMaLoaiPhong",
                principalTable: "LoaiPhong",
                principalColumn: "MaLoaiPhong",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhongTro_LoaiPhong_LoaiPhongsMaLoaiPhong",
                table: "PhongTro");

            migrationBuilder.DropIndex(
                name: "IX_PhongTro_LoaiPhongsMaLoaiPhong",
                table: "PhongTro");

            migrationBuilder.DropColumn(
                name: "LoaiPhongsMaLoaiPhong",
                table: "PhongTro");
        }
    }
}
