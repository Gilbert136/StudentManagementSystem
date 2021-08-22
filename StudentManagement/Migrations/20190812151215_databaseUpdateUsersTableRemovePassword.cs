using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class databaseUpdateUsersTableRemovePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c0b1302-19d2-417f-843f-4d7c0028aeb7", "a86e1455-7376-4d84-8500-4adb1bc33fcd", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5889ffac-35fb-4215-b668-f7b934deaf11", "04e12da6-4885-4227-8fc8-7880ddd558d4", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "56fa2653-2546-437a-a80b-730f628c5614", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "a85f878e-9636-40d0-8db0-389d98b96173", 0, "bae41343-030c-48e9-a8b9-e4a3621d4938", "56fa2653-2546-437a-a80b-730f628c5614", "main@admin.com", true, "Gilbert", "Male", "Adu", false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAEGlsSov6w+LFcjE+7wgq4VsxqnYWMSZOL5xIAGVmKPhN0BmBCzy9CAGCy8XqPuEaBw==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "70ac9605-a40e-4529-ab82-e125fc3345a0", "56fa2653-2546-437a-a80b-730f628c5614", "Introduction To Human Brain" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a85f878e-9636-40d0-8db0-389d98b96173", "6c0b1302-19d2-417f-843f-4d7c0028aeb7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5889ffac-35fb-4215-b668-f7b934deaf11");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a85f878e-9636-40d0-8db0-389d98b96173", "6c0b1302-19d2-417f-843f-4d7c0028aeb7" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "70ac9605-a40e-4529-ab82-e125fc3345a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c0b1302-19d2-417f-843f-4d7c0028aeb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a85f878e-9636-40d0-8db0-389d98b96173");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "56fa2653-2546-437a-a80b-730f628c5614");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                nullable: true);

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
    }
}
