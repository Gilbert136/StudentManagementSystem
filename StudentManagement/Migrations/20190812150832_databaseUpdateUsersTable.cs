using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class databaseUpdateUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28a9bdea-0fd3-4e81-a122-62efa6ca5ecd");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cac8b64e-5585-4a54-86fd-a802a1e2a8d3", "c9803151-dd6a-43b5-afd6-85c62caa7f6b" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "3c4bd85f-aed8-43bc-8e05-da27380aeecd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9803151-dd6a-43b5-afd6-85c62caa7f6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac8b64e-5585-4a54-86fd-a802a1e2a8d3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "0cd7547b-1d91-4c62-b564-8d33baff377d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e063f041-b512-4936-a2c8-0519561410bd", "3b42c6e6-e475-4bd6-a499-c906cfc633fb", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aaf0cfbc-186e-417c-92a5-bc85d8b5f67c", "6c9da1a9-999d-45bf-a712-90d130c42609", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "484e0e8e-eccd-4145-a2e6-5f2facef5549", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "35e2dc18-6c45-47e1-bf04-51188c0b7c75", 0, "ab92eb65-cd5d-4f6e-9f0b-33bb651b2a04", "484e0e8e-eccd-4145-a2e6-5f2facef5549", "main@admin.com", true, "Gilbert", "Male", "Adu", false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", null, "AQAAAAEAACcQAAAAEOBjzroQFeSUPbfC3UWV6LK7CFvqn97wUe/O+oNnFKDxzSj/pvYBewRUgJ4rn31PCA==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "b7d323d8-8600-4072-83a9-d715df3eeebb", "484e0e8e-eccd-4145-a2e6-5f2facef5549", "Introduction To Human Brain" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "35e2dc18-6c45-47e1-bf04-51188c0b7c75", "e063f041-b512-4936-a2c8-0519561410bd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aaf0cfbc-186e-417c-92a5-bc85d8b5f67c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "35e2dc18-6c45-47e1-bf04-51188c0b7c75", "e063f041-b512-4936-a2c8-0519561410bd" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "b7d323d8-8600-4072-83a9-d715df3eeebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e063f041-b512-4936-a2c8-0519561410bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e2dc18-6c45-47e1-bf04-51188c0b7c75");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "484e0e8e-eccd-4145-a2e6-5f2facef5549");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9803151-dd6a-43b5-afd6-85c62caa7f6b", "883ebd7e-98f3-40eb-84ce-fcfa93a7ebfa", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28a9bdea-0fd3-4e81-a122-62efa6ca5ecd", "932ab320-5fd8-4719-9b78-343da191f347", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "0cd7547b-1d91-4c62-b564-8d33baff377d", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "cac8b64e-5585-4a54-86fd-a802a1e2a8d3", 0, "481e7fbc-26aa-4b2d-82c9-101e8efa8bde", "0cd7547b-1d91-4c62-b564-8d33baff377d", "main@admin.com", true, null, null, null, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", null, "AQAAAAEAACcQAAAAEPPWD5J6BTrP2K2Z82TiTogMTCfoAeI+ATVOzar126V034B8OSbgMhH6AAdO57yvjw==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "3c4bd85f-aed8-43bc-8e05-da27380aeecd", "0cd7547b-1d91-4c62-b564-8d33baff377d", "Introduction To Human Brain" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cac8b64e-5585-4a54-86fd-a802a1e2a8d3", "c9803151-dd6a-43b5-afd6-85c62caa7f6b" });
        }
    }
}
