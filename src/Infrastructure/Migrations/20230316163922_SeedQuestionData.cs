using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class SeedQuestionData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Advice", "Section", "Title" },
                values: new object[,]
                {
                    { new Guid("3c64c191-9988-4b54-a48d-8a66f7956cae"), "menyampaikan materi sesuai dengan kontrak kuliah", 0, "materi yang disampaikan sudah sesuai dengan rpp dan rps?" },
                    { new Guid("42389c3d-039b-4429-98dc-771c91171119"), "mencari referensi terkait materi yang diajarkan", 4, "dosen menguasai materi perkuliahan dengan baik?" },
                    { new Guid("4f1eb72e-1d2e-4336-ae51-723950d3765b"), "dosen hadir tepat waktu (maksimal 15 menit)", 3, "dosen hadir tepat waktu" },
                    { new Guid("55a3aae9-1fd4-4d38-9aa4-8f2f786b29c8"), "dosen memberikan nilai uts dan uas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil uts dan uas" },
                    { new Guid("5d282b90-816a-4a46-b1e4-7b0f0681400c"), "dosen memberikan kesempatan bertanya di luar kelas", 1, "dosen memberikan kesempatan bertanya di luar kelas?" },
                    { new Guid("705190ef-7a8c-4426-a05c-14d5204ad44d"), "dosen memberikan kesempatan bertanya di dalam kelas", 1, "dosen memberikan kesempatan bertanya di dalam kelas?" },
                    { new Guid("83121784-77b5-48a1-9a89-d8eb90522205"), "memberikan tugas sesuai dengan kontrak kuliah", 0, "tugas yang diberikan sesuai dengan beban studi?" },
                    { new Guid("a4412013-4411-43ed-bbbf-1c1a39ccc803"), "dosen memanfaatkan forum yang sudah tersedia", 5, "dosen menggunakan forum e-learning?" },
                    { new Guid("c5927270-ea26-4a96-b290-06775a8548c3"), "dosen memanfaatkan konferensi yang sudah tersedia", 5, "dosen menggunakan konferensi video e-learning?" },
                    { new Guid("c7580f0a-a0c5-44f1-a710-8031592174a9"), "dosen memberikan nilai tugas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil tugas" },
                    { new Guid("ddd312fc-0873-4ad5-add4-a309b41733e2"), "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", 3, "perkuliahan dilaksanakan sesuai dengan alokasi waktu" },
                    { new Guid("e919a2c8-c1bb-404d-9cd4-cdf721d92c60"), "dosen memanfaatkan kuis yang sudah tersedia", 5, "dosen menggunakan kuis e-learning?" },
                    { new Guid("f0c571a7-8189-4a47-854d-79234289e2cb"), "dosen memberikan nilai kuis secara terbuka", 2, "dosen secara terbuka menyampaikan hasil kuis" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("3c64c191-9988-4b54-a48d-8a66f7956cae"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("42389c3d-039b-4429-98dc-771c91171119"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("4f1eb72e-1d2e-4336-ae51-723950d3765b"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("55a3aae9-1fd4-4d38-9aa4-8f2f786b29c8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5d282b90-816a-4a46-b1e4-7b0f0681400c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("705190ef-7a8c-4426-a05c-14d5204ad44d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("83121784-77b5-48a1-9a89-d8eb90522205"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("a4412013-4411-43ed-bbbf-1c1a39ccc803"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c5927270-ea26-4a96-b290-06775a8548c3"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c7580f0a-a0c5-44f1-a710-8031592174a9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("ddd312fc-0873-4ad5-add4-a309b41733e2"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("e919a2c8-c1bb-404d-9cd4-cdf721d92c60"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0c571a7-8189-4a47-854d-79234289e2cb"));
        }
    }
}
