using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class addingSubjectDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524ce966-a89d-4fe6-bf32-aa22bb3791e8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0cf34a37-01cd-4588-aa50-a0fcb03d9e80", "e9b8b2ac-cdd0-49e1-bcdd-90a9ae1bcbe3" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "f4e32765-f5d0-48aa-97e6-2c8ddbc12468");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9b8b2ac-cdd0-49e1-bcdd-90a9ae1bcbe3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cf34a37-01cd-4588-aa50-a0fcb03d9e80");

            migrationBuilder.CreateTable(
                name: "Sujects",
                columns: table => new
                {
                    SubjectId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sujects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Sujects_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4ef520d2-01dc-4fc3-88a5-470669614f66", "6f6fdbd5-3b6c-4150-b1d2-467b699d4529", "Administrator", "ADMINISTRATOR" },
                    { "415694a9-13c1-412b-ae28-0695770bbbae", "0b06b550-aad4-4aca-adad-797465483ddf", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "6305864a-d868-4031-9311-ef45631a35d3", 0, "3a4b1253-dcd0-41ef-81f1-8ca7d731709d", "0771db6c-6d2f-4afa-87d8-189d4427e0e4", "main@admin.com", true, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAEKoGm4viV2mG9oOLxeTdhwVkg1RUQ1HiuJQdG5fQUUWbTXh3m3YavZCRO3UfSUFhRQ==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "0771db6c-6d2f-4afa-87d8-189d4427e0e4", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6305864a-d868-4031-9311-ef45631a35d3", "4ef520d2-01dc-4fc3-88a5-470669614f66" });

            migrationBuilder.InsertData(
                table: "Sujects",
                columns: new[] { "SubjectId", "CourseId", "Name" },
                values: new object[] { "de3a8b23-b394-4c14-b538-ff043d378a2f", "0771db6c-6d2f-4afa-87d8-189d4427e0e4", "Introduction To Human Brain" });

            migrationBuilder.CreateIndex(
                name: "IX_Sujects_CourseId",
                table: "Sujects",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sujects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "415694a9-13c1-412b-ae28-0695770bbbae");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6305864a-d868-4031-9311-ef45631a35d3", "4ef520d2-01dc-4fc3-88a5-470669614f66" });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "0771db6c-6d2f-4afa-87d8-189d4427e0e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ef520d2-01dc-4fc3-88a5-470669614f66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6305864a-d868-4031-9311-ef45631a35d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e9b8b2ac-cdd0-49e1-bcdd-90a9ae1bcbe3", "e4bad199-7f8b-425e-bb03-f93f83e7adac", "Administrator", "ADMINISTRATOR" },
                    { "524ce966-a89d-4fe6-bf32-aa22bb3791e8", "b8baa012-565f-4933-bc16-b2074e5aeb50", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TimeStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[] { "0cf34a37-01cd-4588-aa50-a0fcb03d9e80", 0, "8c5f9556-f5a2-4b74-a278-ae590bc0027f", "f4e32765-f5d0-48aa-97e6-2c8ddbc12468", "main@admin.com", true, false, null, "MAIN@ADMIN.COM", "MAIN_ADMIN", "AQAAAAEAACcQAAAAEC85j7i9LSy6ByP4gipdVr2tbo+MYC9xCt7teY0g/suqyCXYZFMNcOC2g5SbAkqJFA==", null, false, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "MAIN_ADMIN", "Administrator" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Name" },
                values: new object[] { "f4e32765-f5d0-48aa-97e6-2c8ddbc12468", "Psychology" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0cf34a37-01cd-4588-aa50-a0fcb03d9e80", "e9b8b2ac-cdd0-49e1-bcdd-90a9ae1bcbe3" });
        }
    }
}
