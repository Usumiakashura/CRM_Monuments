using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MedallionMaterialObjId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_MedallionMaterialObjId",
                table: "PhotoOnMonuments",
                column: "MedallionMaterialObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_MedallionMaterials_MedallionMaterialObjId",
                table: "PhotoOnMonuments",
                column: "MedallionMaterialObjId",
                principalTable: "MedallionMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_MedallionMaterials_MedallionMaterialObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_MedallionMaterialObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "MedallionMaterialObjId",
                table: "PhotoOnMonuments");
        }
    }
}
