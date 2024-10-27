using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class seed_data_düzeltme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Password" },
                values: new object[] { true, "EF92B778BAFE771E89245B89ECBC08A44A4E166C06659911881F383D4473E94F" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Password" },
                values: new object[] { true, "EF92B778BAFE771E89245B89ECBC08A44A4E166C06659911881F383D4473E94F" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Password" },
                values: new object[] { true, "EF92B778BAFE771E89245B89ECBC08A44A4E166C06659911881F383D4473E94F" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Created", "Deleted", "IsActive", "Modified", "Name", "Password" },
                values: new object[] { 4, new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, true, null, "Mustafa", "EF92B778BAFE771E89245B89ECBC08A44A4E166C06659911881F383D4473E94F" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsActive", "Password" },
                values: new object[] { false, "password123" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsActive", "Password" },
                values: new object[] { false, "password123" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsActive", "Password" },
                values: new object[] { false, "password123" });
        }
    }
}
