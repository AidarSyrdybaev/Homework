using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWorkApplication.DAL.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Buckets_UserId",
                table: "Buckets");

            migrationBuilder.AddColumn<int>(
                name: "CafeId",
                table: "Buckets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Buckets_CafeId",
                table: "Buckets",
                column: "CafeId");

            migrationBuilder.CreateIndex(
                name: "IX_Buckets_UserId",
                table: "Buckets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buckets_Cafees_CafeId",
                table: "Buckets",
                column: "CafeId",
                principalTable: "Cafees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buckets_Cafees_CafeId",
                table: "Buckets");

            migrationBuilder.DropIndex(
                name: "IX_Buckets_CafeId",
                table: "Buckets");

            migrationBuilder.DropIndex(
                name: "IX_Buckets_UserId",
                table: "Buckets");

            migrationBuilder.DropColumn(
                name: "CafeId",
                table: "Buckets");

            migrationBuilder.CreateIndex(
                name: "IX_Buckets_UserId",
                table: "Buckets",
                column: "UserId",
                unique: true);
        }
    }
}
