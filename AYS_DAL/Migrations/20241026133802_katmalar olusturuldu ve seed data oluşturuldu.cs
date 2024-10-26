using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AYS_DAL.Migrations
{
    /// <inheritdoc />
    public partial class katmalarolusturulduveseeddataoluşturuldu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Created", "Deleted", "IsActive", "Modified", "Name", "Password" },
                values: new object[] { 1, new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, false, null, "Göksel", "password123" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "Artist", "Created", "Deleted", "Discount", "IsActive", "Modified", "Name", "Price", "ReleaseDate", "Status" },
                values: new object[] { 1, "Serdar Ortaç", new DateTime(2024, 10, 10, 11, 43, 33, 234, DateTimeKind.Local).AddTicks(5286), null, 0.0, false, null, "Mesafe", 55m, new DateOnly(2006, 1, 5), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
