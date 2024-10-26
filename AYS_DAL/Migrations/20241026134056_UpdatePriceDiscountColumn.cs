using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePriceDiscountColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Albums",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "Albums",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 0.0);
        }
    }
}
