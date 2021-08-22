using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class databaseUpdateRemoveCourseField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e6b788b-26a0-4ec9-885a-0c31edaa6033");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ffc6f77-a22a-4dd5-bbec-3e37eb06c9dc", "30a6d9e5-9d4e-4bd2-8397-7c94c52ac309" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "1c081db8-b0ac-4ee3-89f2-cabd08fd1ebe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30a6d9e5-9d4e-4bd2-8397-7c94c52ac309");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ffc6f77-a22a-4dd5-bbec-3e37eb06c9dc");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "69aa3880-17e3-4a39-ba98-a1a39f46c618");

            migrationBuilder.DropColumn(
                name: "Course",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30a6d9e5-9d4e-4bd2-8397-7c94c52ac309", "77eac31b-666f-49b1-a454-cb540bc86358", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e6b788b-26a0-4ec9-885a-0c31edaa6033", "7d1866ea-2d30-4619-b17e-8a70ff20716d", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "69aa3880-17e3-4a39-ba98-a1a39f46c618", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Course", "CourseId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "6ffc6f77-a22a-4dd5-bbec-3e37eb06c9dc", 0, "934bd595-db4c-43a8-88b5-c6752d15bed9", null, "69aa3880-17e3-4a39-ba98-a1a39f46c618", "main@admin.com", true, null, null, null, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", null, "AQAAAAEAACcQAAAAEM2pzjo6lYxGoZ1TKYxDnTK2UcfykCLV6j8ui+2B1/Ag8uRBWl0dFc9Y8j469cexxg==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "1c081db8-b0ac-4ee3-89f2-cabd08fd1ebe", "69aa3880-17e3-4a39-ba98-a1a39f46c618", "Introduction To Human Brain" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6ffc6f77-a22a-4dd5-bbec-3e37eb06c9dc", "30a6d9e5-9d4e-4bd2-8397-7c94c52ac309" });
        }
    }
}
