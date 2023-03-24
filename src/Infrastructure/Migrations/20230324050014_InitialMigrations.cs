using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Section = table.Column<string>(type: "text", nullable: false),
                    Advice = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Respondent = table.Column<string>(type: "text", nullable: false),
                    Lecturer = table.Column<string>(type: "text", nullable: false),
                    QuestionCount = table.Column<int>(type: "integer", nullable: false),
                    AspectCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestions",
                columns: table => new
                {
                    SurveyId = table.Column<Guid>(type: "uuid", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestions", x => new { x.SurveyId, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SurveyQuestionSurveyId = table.Column<Guid>(type: "uuid", nullable: false),
                    SurveyQuestionQuestionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Score = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_SurveyQuestions_SurveyQuestionSurveyId_SurveyQuesti~",
                        columns: x => new { x.SurveyQuestionSurveyId, x.SurveyQuestionQuestionId },
                        principalTable: "SurveyQuestions",
                        principalColumns: new[] { "SurveyId", "QuestionId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Advice", "Section", "Title" },
                values: new object[,]
                {
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), "dosen memberikan kesempatan bertanya di dalam kelas", "kesempatan bertanya", "dosen memberikan kesempatan bertanya di dalam kelas?" },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), "dosen memberikan kesempatan bertanya di luar kelas", "kesempatan bertanya", "dosen memberikan kesempatan bertanya di luar kelas?" },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), "dosen memanfaatkan forum yang sudah tersedia", "penggunaan elearning", "dosen menggunakan forum e-learning?" },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), "dosen memanfaatkan kuis yang sudah tersedia", "penggunaan elearning", "dosen menggunakan kuis e-learning?" },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), "dosen memanfaatkan konferensi yang sudah tersedia", "penggunaan elearning", "dosen menggunakan konferensi video e-learning?" },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), "dosen memberikan nilai tugas secara terbuka", "transparansi nilai", "dosen secara terbuka menyampaikan hasil tugas" },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), "dosen memberikan nilai kuis secara terbuka", "transparansi nilai", "dosen secara terbuka menyampaikan hasil kuis" },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), "dosen memberikan nilai uts dan uas secara terbuka", "transparansi nilai", "dosen secara terbuka menyampaikan hasil uts dan uas" },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), "dosen hadir tepat waktu (maksimal 15 menit)", "kedisiplinan waktu", "dosen hadir tepat waktu" },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", "kedisiplinan waktu", "perkuliahan dilaksanakan sesuai dengan alokasi waktu" },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), "menyampaikan materi sesuai dengan kontrak kuliah", "rencana kontrak kuliah", "materi yang disampaikan sudah sesuai dengan rpp dan rps?" },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), "memberikan tugas sesuai dengan kontrak kuliah", "rencana kontrak kuliah", "tugas yang diberikan sesuai dengan beban studi?" },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), "mencari referensi terkait materi yang diajarkan", "penguasaan materi", "dosen menguasai materi perkuliahan dengan baik?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SurveyQuestionSurveyId_SurveyQuestionQuestionId",
                table: "Answers",
                columns: new[] { "SurveyQuestionSurveyId", "SurveyQuestionQuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestions_QuestionId",
                table: "SurveyQuestions",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "SurveyQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
