using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Data.Migrations
{
    public partial class SeedEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DateOfHire", "FirstName", "LastName", "PhoneNumber", "Role" },
                values: new object[,]
                {
                    { 2, new DateTime(1990, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Smith", "555-234-5678", 5 },
                    { 3, new DateTime(1982, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2008, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Johnson", "555-345-6789", 1 },
                    { 4, new DateTime(1993, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", "Davis", "555-456-7890", 3 },
                    { 5, new DateTime(1978, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", "Lee", "555-567-8901", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
