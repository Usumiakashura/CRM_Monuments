using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateBeginTextEpitaph",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "DateCompleatTextEpitaph",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "EngraverEpitaph",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "Epitaph",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "NotesTextEpitaph",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "TypeNameEpitaph",
                table: "Deceaseds");

            migrationBuilder.AddColumn<int>(
                name: "TypeTextId",
                table: "Deceaseds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Epitaphs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    EpitaphBool = table.Column<bool>(type: "bit", nullable: false),
                    TypeTextEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeTextObjId = table.Column<int>(type: "int", nullable: true),
                    NotesTextEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EngraverEpitaph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBeginTextEpitaph = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCompleatTextEpitaph = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Epitaphs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Epitaphs_Deceaseds_Id",
                        column: x => x.Id,
                        principalTable: "Deceaseds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Epitaphs_TypeTexts_TypeTextObjId",
                        column: x => x.TypeTextObjId,
                        principalTable: "TypeTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deceaseds_TypeTextId",
                table: "Deceaseds",
                column: "TypeTextId");

            migrationBuilder.CreateIndex(
                name: "IX_Epitaphs_TypeTextObjId",
                table: "Epitaphs",
                column: "TypeTextObjId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deceaseds_TypeTexts_TypeTextId",
                table: "Deceaseds",
                column: "TypeTextId",
                principalTable: "TypeTexts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deceaseds_TypeTexts_TypeTextId",
                table: "Deceaseds");

            migrationBuilder.DropTable(
                name: "Epitaphs");

            migrationBuilder.DropIndex(
                name: "IX_Deceaseds_TypeTextId",
                table: "Deceaseds");

            migrationBuilder.DropColumn(
                name: "TypeTextId",
                table: "Deceaseds");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateBeginTextEpitaph",
                table: "Deceaseds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCompleatTextEpitaph",
                table: "Deceaseds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EngraverEpitaph",
                table: "Deceaseds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Epitaph",
                table: "Deceaseds",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "NotesTextEpitaph",
                table: "Deceaseds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeNameEpitaph",
                table: "Deceaseds",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
