using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "583 Wall Dr. Gwynn Oak, MD 21200", "USA", "IT_Solutions Ltd" },
                    { new Guid("e1fde970-910e-45b5-a835-8a7208eff896"), "325 Forest Avenue, BF 359", "USA", "Admin_Solutions Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("22c8131c-dc68-4281-a02f-411fe3a79702"), 30, new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "Gil Nevo", "Software Developer" },
                    { new Guid("4772542c-e3cb-46b6-b64a-885754a2ebfd"), 35, new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "Daniel Madhala", "Software Developer" },
                    { new Guid("902268d7-6d13-40d7-8d44-b1a9b67bb9d1"), 85, new Guid("e1fde970-910e-45b5-a835-8a7208eff896"), "Boris Johnson", "Administrator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("22c8131c-dc68-4281-a02f-411fe3a79702"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("4772542c-e3cb-46b6-b64a-885754a2ebfd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("902268d7-6d13-40d7-8d44-b1a9b67bb9d1"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c3001bfb-4754-4336-8815-687d96bb1958"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("e1fde970-910e-45b5-a835-8a7208eff896"));
        }
    }
}
