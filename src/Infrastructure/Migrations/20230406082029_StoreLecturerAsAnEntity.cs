using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class StoreLecturerAsAnEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lecturer",
                table: "Surveys");

            migrationBuilder.AddColumn<Guid>(
                name: "LecturerId",
                table: "Surveys",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_LecturerId",
                table: "Surveys",
                column: "LecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_Lecturers_LecturerId",
                table: "Surveys",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_Lecturers_LecturerId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "Lecturers");

            migrationBuilder.DropIndex(
                name: "IX_Surveys_LecturerId",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "LecturerId",
                table: "Surveys");

            migrationBuilder.AddColumn<string>(
                name: "Lecturer",
                table: "Surveys",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
