using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitObjId",
                table: "PhotoOnMonuments");

            migrationBuilder.RenameColumn(
                name: "TypePortraitObjId",
                table: "PhotoOnMonuments",
                newName: "TypePortraitId");

            migrationBuilder.RenameColumn(
                name: "TypePortrait",
                table: "PhotoOnMonuments",
                newName: "TypePortraitName");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoOnMonuments_TypePortraitObjId",
                table: "PhotoOnMonuments",
                newName: "IX_PhotoOnMonuments_TypePortraitId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitId",
                table: "PhotoOnMonuments",
                column: "TypePortraitId",
                principalTable: "TypePortraits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitId",
                table: "PhotoOnMonuments");

            migrationBuilder.RenameColumn(
                name: "TypePortraitName",
                table: "PhotoOnMonuments",
                newName: "TypePortrait");

            migrationBuilder.RenameColumn(
                name: "TypePortraitId",
                table: "PhotoOnMonuments",
                newName: "TypePortraitObjId");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoOnMonuments_TypePortraitId",
                table: "PhotoOnMonuments",
                newName: "IX_PhotoOnMonuments_TypePortraitObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoOnMonuments_TypePortraits_TypePortraitObjId",
                table: "PhotoOnMonuments",
                column: "TypePortraitObjId",
                principalTable: "TypePortraits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
