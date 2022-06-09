using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class NewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalerRecord_Seller_SellerId",
                table: "SalerRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalerRecord",
                table: "SalerRecord");

            migrationBuilder.RenameTable(
                name: "SalerRecord",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalerRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AlterColumn<double>(
                name: "BaseSalary",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                table: "SalesRecord",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SalerRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalerRecord",
                newName: "IX_SalerRecord_SellerId");

            migrationBuilder.AlterColumn<float>(
                name: "BaseSalary",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "SalerRecord",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalerRecord",
                table: "SalerRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalerRecord_Seller_SellerId",
                table: "SalerRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
