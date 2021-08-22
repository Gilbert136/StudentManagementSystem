using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class addingSubjectDBRenameRecofig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2821f6eb-02e7-4dd1-a120-67620e18b314");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c286c910-0ad0-48de-87e3-10f3943abab4", "e3935860-4585-41a7-b056-6d89fe7a1b7c" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "a7a32472-e7e0-4cba-94fa-f2f80110860d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3935860-4585-41a7-b056-6d89fe7a1b7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c286c910-0ad0-48de-87e3-10f3943abab4");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "f76ee6ff-8bfe-4afe-970d-c6a94fb8207b");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "e3935860-4585-41a7-b056-6d89fe7a1b7c", "ba9703a7-0a2c-4867-b31e-2663c6f60733", "Administrator", "ADMINISTRATOR" },
                    { "2821f6eb-02e7-4dd1-a120-67620e18b314", "a72e97fa-2751-4d85-b0b3-a0762260468a", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "c286c910-0ad0-48de-87e3-10f3943abab4", 0, "d0e81938-4a29-499b-9fdf-70cc11071474", "f76ee6ff-8bfe-4afe-970d-c6a94fb8207b", "main@admin.com", true, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAEBbvyX1UEZ8H9cazcaBsh5dplKcqyw8MvX/kSXH4dh/G2Xc/0LwxZIjmpjKcVl97iw==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "f76ee6ff-8bfe-4afe-970d-c6a94fb8207b", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c286c910-0ad0-48de-87e3-10f3943abab4", "e3935860-4585-41a7-b056-6d89fe7a1b7c" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "a7a32472-e7e0-4cba-94fa-f2f80110860d", "f76ee6ff-8bfe-4afe-970d-c6a94fb8207b", "Introduction To Human Brain" });
        }
    }
}
