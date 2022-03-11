using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class testMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypePortraitObjId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_TypePortraitObjId",
                table: "PhotoOnMonuments",
                column: "TypePortraitObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitObjId",
                table: "PhotoOnMonuments",
                column: "TypePortraitObjId",
                principalTable: "TypePortraits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_TypePortraitObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "TypePortraitObjId",
                table: "PhotoOnMonuments");
        }
    }
}
