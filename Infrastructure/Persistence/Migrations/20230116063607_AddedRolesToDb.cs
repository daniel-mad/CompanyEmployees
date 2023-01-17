using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("15e8a619-a01f-4186-8ec1-a9dde9e8d31e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("373faa5d-18ee-4fe3-b6bf-7271edea826b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e0d8f231-c383-4c19-9a1b-bb5be2c6d206"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "009f061a-97a0-4d4a-8ceb-ef6ebe3947bb", "9bac5ca7-e423-4a1d-9e72-8177f2932207", "Manager", "MANAGER" },
                    { "10ca2f55-d35a-4480-bd6f-a100625bc4ae", "3e5aa504-398d-46fe-baa8-37a2bcf88ece", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("0fdabd65-b725-4528-84c0-3cffb56b6402"), 85, new Guid("e1fde970-910e-45b5-a835-8a7208eff896"), "Boris Johnson", "Administrator" },
                    { new Guid("776f1b37-55c9-4825-8605-8c8950bbe3d9"), 35, new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "Daniel Madhala", "Software Developer" },
                    { new Guid("e9457fbb-10b4-45df-9ecd-c9c6526c9168"), 30, new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "Gil Nevo", "Software Developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "009f061a-97a0-4d4a-8ceb-ef6ebe3947bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10ca2f55-d35a-4480-bd6f-a100625bc4ae");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("0fdabd65-b725-4528-84c0-3cffb56b6402"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("776f1b37-55c9-4825-8605-8c8950bbe3d9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e9457fbb-10b4-45df-9ecd-c9c6526c9168"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("15e8a619-a01f-4186-8ec1-a9dde9e8d31e"), 30, new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "Gil Nevo", "Software Developer" },
                    { new Guid("373faa5d-18ee-4fe3-b6bf-7271edea826b"), 85, new Guid("e1fde970-910e-45b5-a835-8a7208eff896"), "Boris Johnson", "Administrator" },
                    { new Guid("e0d8f231-c383-4c19-9a1b-bb5be2c6d206"), 35, new Guid("c3001bfb-4754-4336-8815-687d96bb1958"), "Daniel Madhala", "Software Developer" }
                });
        }
    }
}
