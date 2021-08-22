using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Migrations
{
    public partial class addingSubjectDBRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sujects_Courses_CourseId",
                table: "Sujects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sujects",
                table: "Sujects");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "415694a9-13c1-412b-ae28-0695770bbbae");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6305864a-d868-4031-9311-ef45631a35d3", "4ef520d2-01dc-4fc3-88a5-470669614f66" });

            migrationBuilder.DeleteData(
                table: "Sujects",
                keyColumn: "SubjectId",
                keyValue: "de3a8b23-b394-4c14-b538-ff043d378a2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4ef520d2-01dc-4fc3-88a5-470669614f66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6305864a-d868-4031-9311-ef45631a35d3");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: "0771db6c-6d2f-4afa-87d8-189d4427e0e4");

            migrationBuilder.RenameTable(
                name: "Sujects",
                newName: "Subjects");

            migrationBuilder.RenameIndex(
                name: "IX_Sujects_CourseId",
                table: "Subjects",
                newName: "IX_Subjects_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

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

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Sujects");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_CourseId",
                table: "Sujects",
                newName: "IX_Sujects_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sujects",
                table: "Sujects",
                column: "SubjectId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Sujects_Courses_CourseId",
                table: "Sujects",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
