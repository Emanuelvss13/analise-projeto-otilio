using Microsoft.EntityFrameworkCore.Migrations;

namespace OtilioFinal.Migrations
{
    public partial class methods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departmentid",
                table: "Seller",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sellerid",
                table: "SalesRecord",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_Departmentid",
                table: "Seller",
                column: "Departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_Sellerid",
                table: "SalesRecord",
                column: "Sellerid");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_Sellerid",
                table: "SalesRecord",
                column: "Sellerid",
                principalTable: "Seller",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller",
                column: "Departmentid",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_Sellerid",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_Departmentid",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_Sellerid",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "Departmentid",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "Sellerid",
                table: "SalesRecord");
        }
    }
}
