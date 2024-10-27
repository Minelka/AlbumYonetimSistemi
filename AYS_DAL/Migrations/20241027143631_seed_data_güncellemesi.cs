using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AYS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class seed_data_güncellemesi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Created", "Deleted", "Discount", "IsActive", "Modified", "Name", "Price", "ReleaseDate", "Status" },
                values: new object[,]
                {
                    { 2, "Teoman", new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, 0.10m, false, null, "onyedi", 975m, new DateOnly(2000, 4, 28), false },
                    { 3, "Eurythmics", new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, 0.2m, false, null, "Touch", 450m, new DateOnly(1983, 1, 1), false },
                    { 4, "Kayahan", new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, 0m, false, null, "Gönül Sayfam", 975m, new DateOnly(2000, 1, 1), false },
                    { 5, "Yüzyüzeyken Konuşuruz", new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, 0m, false, null, "Akustik Travma", 975m, new DateOnly(2018, 1, 1), false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
