using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class databaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78b9e67-c2cd-410c-8f6d-fc67e37a049d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "720a0760-e256-44f8-8c70-3d727dcc635a", "b7388907-5ed8-4ad8-bb2d-3b31f723ed9d" });

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "SubjectId",
                keyValue: "980dab0f-897e-46e6-824c-1fa85dadfc4c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7388907-5ed8-4ad8-bb2d-3b31f723ed9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "720a0760-e256-44f8-8c70-3d727dcc635a");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "f2ed3d9f-1000-4060-a695-e8b9f48ca4c0");

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7388907-5ed8-4ad8-bb2d-3b31f723ed9d", "7b1e1814-08f3-49d8-86f3-8ea17d5e585b", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c78b9e67-c2cd-410c-8f6d-fc67e37a049d", "4471f8ac-82ad-41f2-bbdd-cbd60074ca87", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "f2ed3d9f-1000-4060-a695-e8b9f48ca4c0", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "720a0760-e256-44f8-8c70-3d727dcc635a", 0, "8766e068-6369-48af-8f6e-bba14cc9a17a", "f2ed3d9f-1000-4060-a695-e8b9f48ca4c0", "main@admin.com", true, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAELJgWG/fNbB4oI1zOZ0tDWQBG3Lx0Gq7enegm+pJLK94XGUxYYlpvKDmLb9r8/2GCw==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "980dab0f-897e-46e6-824c-1fa85dadfc4c", "f2ed3d9f-1000-4060-a695-e8b9f48ca4c0", "Introduction To Human Brain" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "720a0760-e256-44f8-8c70-3d727dcc635a", "b7388907-5ed8-4ad8-bb2d-3b31f723ed9d" });
        }
    }
}
