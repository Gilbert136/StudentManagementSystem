using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class reconfigureDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CourseId",
                table: "AspNetUsers",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Courses_CourseId",
                table: "AspNetUsers",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Courses_CourseId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CourseId",
                table: "AspNetUsers");

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

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
