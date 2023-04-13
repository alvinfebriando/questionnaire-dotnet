using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class ImproveQuestionFluency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memberikan kesempatan bertanya di dalam kelas", "Apakah dosen memberikan kesempatan bertanya di dalam kelas?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memberikan kesempatan bertanya di luar kelas", "Apakah dosen memberikan kesempatan bertanya di luar kelas?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memanfaatkan fitur forum yang sudah tersedia", "Apakah dosen menggunakan fitur forum e-learning?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memanfaatkan fitur kuis yang sudah tersedia", "Apakah dosen menggunakan fitur kuis e-learning?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memanfaatkan fitur konferensi video yang sudah tersedia", "Apakah dosen menggunakan fitur konferensi video e-learning?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memberikan nilai tugas secara terbuka", "Apakah dosen secara terbuka menyampaikan hasil tugas" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memberikan nilai kuis secara terbuka", "Apakah dosen secara terbuka menyampaikan hasil kuis" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memberikan nilai uts dan uas secara terbuka", "Apakah dosen secara terbuka menyampaikan hasil uts dan uas" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "hadir tepat waktu (maksimal 15 menit keterlambatan)", "Apakah dosen hadir tepat waktu" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", "Apakah perkuliahan dilaksanakan sesuai dengan alokasi waktu" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"),
                column: "Title",
                value: "Apakah materi yang disampaikan sudah sesuai dengan rpp dan rps?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"),
                column: "Title",
                value: "Apakah tugas yang diberikan sesuai dengan beban studi?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"),
                column: "Title",
                value: "Apakah dosen menguasai materi perkuliahan dengan baik?");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memberikan kesempatan bertanya di dalam kelas", "dosen memberikan kesempatan bertanya di dalam kelas?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memberikan kesempatan bertanya di luar kelas", "dosen memberikan kesempatan bertanya di luar kelas?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memanfaatkan forum yang sudah tersedia", "dosen menggunakan forum e-learning?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memanfaatkan kuis yang sudah tersedia", "dosen menggunakan kuis e-learning?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memanfaatkan konferensi yang sudah tersedia", "dosen menggunakan konferensi video e-learning?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memberikan nilai tugas secara terbuka", "dosen secara terbuka menyampaikan hasil tugas" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memberikan nilai kuis secara terbuka", "dosen secara terbuka menyampaikan hasil kuis" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memberikan nilai uts dan uas secara terbuka", "dosen secara terbuka menyampaikan hasil uts dan uas" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen hadir tepat waktu (maksimal 15 menit)", "dosen hadir tepat waktu" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"),
                columns: new[] { "Advice", "Title" },
                values: new object[] { "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", "perkuliahan dilaksanakan sesuai dengan alokasi waktu" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"),
                column: "Title",
                value: "materi yang disampaikan sudah sesuai dengan rpp dan rps?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"),
                column: "Title",
                value: "tugas yang diberikan sesuai dengan beban studi?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"),
                column: "Title",
                value: "dosen menguasai materi perkuliahan dengan baik?");
        }
    }
}
