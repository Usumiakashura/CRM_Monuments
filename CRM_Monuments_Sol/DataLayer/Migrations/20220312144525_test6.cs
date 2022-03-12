using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorMedallionObjId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShapeMedallionObjId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_ColorMedallionObjId",
                table: "PhotoOnMonuments",
                column: "ColorMedallionObjId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_ShapeMedallionObjId",
                table: "PhotoOnMonuments",
                column: "ShapeMedallionObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_ColorMedallions_ColorMedallionObjId",
                table: "PhotoOnMonuments",
                column: "ColorMedallionObjId",
                principalTable: "ColorMedallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_ShapeMedallions_ShapeMedallionObjId",
                table: "PhotoOnMonuments",
                column: "ShapeMedallionObjId",
                principalTable: "ShapeMedallions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_ColorMedallions_ColorMedallionObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_ShapeMedallions_ShapeMedallionObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_ColorMedallionObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_ShapeMedallionObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "ColorMedallionObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "ShapeMedallionObjId",
                table: "PhotoOnMonuments");
        }
    }
}
