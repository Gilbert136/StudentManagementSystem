using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class addingSubjectDBRenameRecofig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "124e717f-4233-4b56-8a54-216d1813671c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a1e27842-3626-4073-8ee0-703729cf3f26", "ad1e7dfd-ef22-496e-893b-e3e1b160dc34" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "f7f8a928-5c2c-4aee-bc7f-c2cf8d1c0486");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad1e7dfd-ef22-496e-893b-e3e1b160dc34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1e27842-3626-4073-8ee0-703729cf3f26");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "7f7fa791-2d43-4789-98eb-49eb6d0a4aa4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76831acd-b39e-4d5c-963f-44804d9e534d", "88fbcee0-71c6-42bb-9158-92b0702b593f", "Administrator", "ADMINISTRATOR" },
                    { "52fae764-5415-44f7-8251-8207a2991476", "f1c5211e-fe1d-4823-85b5-ee2d1391fe60", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "4909d174-7671-4c74-8f9b-6138ad57d7b7", 0, "cd70347d-e189-44f9-843b-ab52aa0a68ab", "74e5cae5-28fe-4cb5-a62d-720b44191fd7", "main@admin.com", true, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAEF/ADbovnwR/rPgbv+1gVSRV+tFoHEq/VnNbNE2YiunJj1Hx/d3a8OPmptDvg9fxvQ==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "74e5cae5-28fe-4cb5-a62d-720b44191fd7", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4909d174-7671-4c74-8f9b-6138ad57d7b7", "76831acd-b39e-4d5c-963f-44804d9e534d" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "54daa0ff-87bd-49fe-9950-5e12b1aa0bd2", "74e5cae5-28fe-4cb5-a62d-720b44191fd7", "Introduction To Human Brain" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52fae764-5415-44f7-8251-8207a2991476");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4909d174-7671-4c74-8f9b-6138ad57d7b7", "76831acd-b39e-4d5c-963f-44804d9e534d" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "54daa0ff-87bd-49fe-9950-5e12b1aa0bd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76831acd-b39e-4d5c-963f-44804d9e534d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4909d174-7671-4c74-8f9b-6138ad57d7b7");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "74e5cae5-28fe-4cb5-a62d-720b44191fd7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad1e7dfd-ef22-496e-893b-e3e1b160dc34", "a6a2c640-340a-4ffe-b277-46e91bb7f667", "Administrator", "ADMINISTRATOR" },
                    { "124e717f-4233-4b56-8a54-216d1813671c", "f722c519-a6f1-445f-aa62-d2eeae9489c4", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "a1e27842-3626-4073-8ee0-703729cf3f26", 0, "19bf949e-1681-4ce5-843a-3424dace8e9d", "7f7fa791-2d43-4789-98eb-49eb6d0a4aa4", "main@admin.com", true, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAEN6Wln9dVI+jn+G1gRcaLzT5boHlXce+SBHd6D5FeR5e7wR4WG6qtC4UpjmI6ZD4uA==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "7f7fa791-2d43-4789-98eb-49eb6d0a4aa4", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a1e27842-3626-4073-8ee0-703729cf3f26", "ad1e7dfd-ef22-496e-893b-e3e1b160dc34" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "f7f8a928-5c2c-4aee-bc7f-c2cf8d1c0486", "7f7fa791-2d43-4789-98eb-49eb6d0a4aa4", "Introduction To Human Brain" });
        }
    }
}
