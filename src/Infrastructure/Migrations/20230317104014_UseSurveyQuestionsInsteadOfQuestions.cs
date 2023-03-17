using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class UseSurveyQuestionsInsteadOfQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0147be83-3498-4596-9fca-046777f344d5"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("29ca623c-1024-445e-80f2-c56159465f0d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3e6f9ce1-1f2b-4cf9-87cb-f39c6d042616"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8a6e7e06-63aa-4fe0-9119-ea6840f3a6c1"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9054deeb-af13-4497-a21d-898acb240257"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("922e4d6d-05dd-45f2-a489-b512a0b78486"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9ece3702-0ff4-4624-b1b6-821b676aa15b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a0e5a483-104d-4bf6-b65b-6d0047f5c2eb"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("bbffa9a7-41d1-46c0-b5c3-9f9f6e817e30"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c2e4c137-e3d7-4bef-80c0-f76d3bc1eae2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("cc0c1b7d-991e-4357-906f-e9296fe7f2bd"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e5ad7297-ad27-49da-85c3-38cd231c1c74"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f1c160b1-2150-4969-868a-b5b75cd738a5"));

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Answers",
                newName: "SurveyQuestionSurveyId");

            migrationBuilder.AddColumn<Guid>(
                name: "SurveyQuestionQuestionId",
                table: "Answers",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Advice", "Section", "Title" },
                values: new object[,]
                {
                    { new Guid("0fa4bc64-7337-4980-95a9-d97514163135"), "memberikan tugas sesuai dengan kontrak kuliah", 0, "tugas yang diberikan sesuai dengan beban studi?" },
                    { new Guid("1b5ea83d-f546-4b58-8108-7aef5d77e4d2"), "dosen memberikan kesempatan bertanya di dalam kelas", 1, "dosen memberikan kesempatan bertanya di dalam kelas?" },
                    { new Guid("22d85ad6-bc99-4586-a6c8-1e43595155d4"), "dosen memberikan nilai kuis secara terbuka", 2, "dosen secara terbuka menyampaikan hasil kuis" },
                    { new Guid("461f9e9a-af58-4fde-b855-e147a472b39f"), "dosen memberikan nilai tugas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil tugas" },
                    { new Guid("60b5fea8-8f20-4f1f-9d05-e62a04eb71e8"), "dosen memberikan kesempatan bertanya di luar kelas", 1, "dosen memberikan kesempatan bertanya di luar kelas?" },
                    { new Guid("77158d16-81f0-44e7-ab7f-45e82a242d85"), "dosen memanfaatkan kuis yang sudah tersedia", 5, "dosen menggunakan kuis e-learning?" },
                    { new Guid("875ab61b-0291-455f-aa70-803d05c8d04b"), "dosen hadir tepat waktu (maksimal 15 menit)", 3, "dosen hadir tepat waktu" },
                    { new Guid("9b740909-3621-42ee-b348-2bb0e6d56638"), "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", 3, "perkuliahan dilaksanakan sesuai dengan alokasi waktu" },
                    { new Guid("a37b10cd-dd8d-484b-a912-379bcdb33a5b"), "dosen memanfaatkan konferensi yang sudah tersedia", 5, "dosen menggunakan konferensi video e-learning?" },
                    { new Guid("c5fccd94-37ed-4089-b7a2-25cc7dbf6e3e"), "dosen memberikan nilai uts dan uas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil uts dan uas" },
                    { new Guid("ca393deb-3cc7-4913-b551-0319bd20d5d4"), "mencari referensi terkait materi yang diajarkan", 4, "dosen menguasai materi perkuliahan dengan baik?" },
                    { new Guid("fe47e398-76e4-45ee-a0c1-c382d5c8fa67"), "menyampaikan materi sesuai dengan kontrak kuliah", 0, "materi yang disampaikan sudah sesuai dengan rpp dan rps?" },
                    { new Guid("ffa5fcc2-37d6-4635-9aac-61e72007edb3"), "dosen memanfaatkan forum yang sudah tersedia", 5, "dosen menggunakan forum e-learning?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_SurveyQuestionSurveyId_SurveyQuestionQuestionId",
                table: "Answers",
                columns: new[] { "SurveyQuestionSurveyId", "SurveyQuestionQuestionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_SurveyQuestions_SurveyQuestionSurveyId_SurveyQuesti~",
                table: "Answers",
                columns: new[] { "SurveyQuestionSurveyId", "SurveyQuestionQuestionId" },
                principalTable: "SurveyQuestions",
                principalColumns: new[] { "SurveyId", "QuestionId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_SurveyQuestions_SurveyQuestionSurveyId_SurveyQuesti~",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_SurveyQuestionSurveyId_SurveyQuestionQuestionId",
                table: "Answers");

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("0fa4bc64-7337-4980-95a9-d97514163135"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1b5ea83d-f546-4b58-8108-7aef5d77e4d2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("22d85ad6-bc99-4586-a6c8-1e43595155d4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("461f9e9a-af58-4fde-b855-e147a472b39f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("60b5fea8-8f20-4f1f-9d05-e62a04eb71e8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("77158d16-81f0-44e7-ab7f-45e82a242d85"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("875ab61b-0291-455f-aa70-803d05c8d04b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("9b740909-3621-42ee-b348-2bb0e6d56638"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a37b10cd-dd8d-484b-a912-379bcdb33a5b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c5fccd94-37ed-4089-b7a2-25cc7dbf6e3e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ca393deb-3cc7-4913-b551-0319bd20d5d4"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fe47e398-76e4-45ee-a0c1-c382d5c8fa67"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ffa5fcc2-37d6-4635-9aac-61e72007edb3"));

            migrationBuilder.DropColumn(
                name: "SurveyQuestionQuestionId",
                table: "Answers");

            migrationBuilder.RenameColumn(
                name: "SurveyQuestionSurveyId",
                table: "Answers",
                newName: "QuestionId");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Advice", "Section", "Title" },
                values: new object[,]
                {
                    { new Guid("0147be83-3498-4596-9fca-046777f344d5"), "dosen memanfaatkan forum yang sudah tersedia", 5, "dosen menggunakan forum e-learning?" },
                    { new Guid("29ca623c-1024-445e-80f2-c56159465f0d"), "dosen memanfaatkan konferensi yang sudah tersedia", 5, "dosen menggunakan konferensi video e-learning?" },
                    { new Guid("3e6f9ce1-1f2b-4cf9-87cb-f39c6d042616"), "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", 3, "perkuliahan dilaksanakan sesuai dengan alokasi waktu" },
                    { new Guid("8a6e7e06-63aa-4fe0-9119-ea6840f3a6c1"), "dosen memberikan nilai uts dan uas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil uts dan uas" },
                    { new Guid("9054deeb-af13-4497-a21d-898acb240257"), "dosen memberikan nilai tugas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil tugas" },
                    { new Guid("922e4d6d-05dd-45f2-a489-b512a0b78486"), "mencari referensi terkait materi yang diajarkan", 4, "dosen menguasai materi perkuliahan dengan baik?" },
                    { new Guid("9ece3702-0ff4-4624-b1b6-821b676aa15b"), "dosen memanfaatkan kuis yang sudah tersedia", 5, "dosen menggunakan kuis e-learning?" },
                    { new Guid("a0e5a483-104d-4bf6-b65b-6d0047f5c2eb"), "dosen hadir tepat waktu (maksimal 15 menit)", 3, "dosen hadir tepat waktu" },
                    { new Guid("bbffa9a7-41d1-46c0-b5c3-9f9f6e817e30"), "memberikan tugas sesuai dengan kontrak kuliah", 0, "tugas yang diberikan sesuai dengan beban studi?" },
                    { new Guid("c2e4c137-e3d7-4bef-80c0-f76d3bc1eae2"), "menyampaikan materi sesuai dengan kontrak kuliah", 0, "materi yang disampaikan sudah sesuai dengan rpp dan rps?" },
                    { new Guid("cc0c1b7d-991e-4357-906f-e9296fe7f2bd"), "dosen memberikan nilai kuis secara terbuka", 2, "dosen secara terbuka menyampaikan hasil kuis" },
                    { new Guid("e5ad7297-ad27-49da-85c3-38cd231c1c74"), "dosen memberikan kesempatan bertanya di dalam kelas", 1, "dosen memberikan kesempatan bertanya di dalam kelas?" },
                    { new Guid("f1c160b1-2150-4969-868a-b5b75cd738a5"), "dosen memberikan kesempatan bertanya di luar kelas", 1, "dosen memberikan kesempatan bertanya di luar kelas?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
