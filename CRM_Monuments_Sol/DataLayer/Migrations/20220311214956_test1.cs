using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypePortraitId",
                table: "PhotoOnMonuments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhotoOnMonuments_TypePortraitId",
                table: "PhotoOnMonuments",
                column: "TypePortraitId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitId",
                table: "PhotoOnMonuments",
                column: "TypePortraitId",
                principalTable: "TypePortraits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropIndex(
                name: "IX_PhotoOnMonuments_TypePortraitId",
                table: "PhotoOnMonuments");

            migrationBuilder.DropColumn(
                name: "TypePortraitId",
                table: "PhotoOnMonuments");
        }
    }
}
