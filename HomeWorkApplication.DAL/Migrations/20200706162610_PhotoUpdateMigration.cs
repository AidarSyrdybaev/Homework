using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkApplication.DAL.Migrations
{
    public partial class PhotoUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "Dishes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DishPictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DishId = table.Column<int>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishPictures_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_DishId",
                table: "Dishes",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishPictures_DishId",
                table: "DishPictures",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Dishes_DishId",
                table: "Dishes",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Dishes_DishId",
                table: "Dishes");

            migrationBuilder.DropTable(
                name: "DishPictures");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_DishId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "Dishes");
        }
    }
}
