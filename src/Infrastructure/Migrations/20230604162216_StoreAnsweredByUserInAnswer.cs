using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class StoreAnsweredByUserInAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyUser");

            migrationBuilder.AddColumn<Guid>(
                name: "AnsweredByUserId",
                table: "Answers",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_AnsweredByUserId",
                table: "Answers",
                column: "AnsweredByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Users_AnsweredByUserId",
                table: "Answers",
                column: "AnsweredByUserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Users_AnsweredByUserId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_AnsweredByUserId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "AnsweredByUserId",
                table: "Answers");

            migrationBuilder.CreateTable(
                name: "SurveyUser",
                columns: table => new
                {
                    AnsweredById = table.Column<Guid>(type: "uuid", nullable: false),
                    SurveysId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyUser", x => new { x.AnsweredById, x.SurveysId });
                    table.ForeignKey(
                        name: "FK_SurveyUser_Surveys_SurveysId",
                        column: x => x.SurveysId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyUser_Users_AnsweredById",
                        column: x => x.AnsweredById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyUser_SurveysId",
                table: "SurveyUser",
                column: "SurveysId");
        }
    }
}
