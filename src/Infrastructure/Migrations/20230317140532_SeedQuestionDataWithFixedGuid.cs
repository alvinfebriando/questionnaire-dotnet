using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class SeedQuestionDataWithFixedGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Advice", "Section", "Title" },
                values: new object[,]
                {
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), "dosen memberikan kesempatan bertanya di dalam kelas", 1, "dosen memberikan kesempatan bertanya di dalam kelas?" },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), "dosen memberikan kesempatan bertanya di luar kelas", 1, "dosen memberikan kesempatan bertanya di luar kelas?" },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), "dosen memanfaatkan forum yang sudah tersedia", 5, "dosen menggunakan forum e-learning?" },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), "dosen memanfaatkan kuis yang sudah tersedia", 5, "dosen menggunakan kuis e-learning?" },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), "dosen memanfaatkan konferensi yang sudah tersedia", 5, "dosen menggunakan konferensi video e-learning?" },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), "dosen memberikan nilai tugas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil tugas" },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), "dosen memberikan nilai kuis secara terbuka", 2, "dosen secara terbuka menyampaikan hasil kuis" },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), "dosen memberikan nilai uts dan uas secara terbuka", 2, "dosen secara terbuka menyampaikan hasil uts dan uas" },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), "dosen hadir tepat waktu (maksimal 15 menit)", 3, "dosen hadir tepat waktu" },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), "dosen memberikan perkuliahan sesuai dengan sesi yang sudah dialokasikan", 3, "perkuliahan dilaksanakan sesuai dengan alokasi waktu" },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), "menyampaikan materi sesuai dengan kontrak kuliah", 0, "materi yang disampaikan sudah sesuai dengan rpp dan rps?" },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), "memberikan tugas sesuai dengan kontrak kuliah", 0, "tugas yang diberikan sesuai dengan beban studi?" },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), "mencari referensi terkait materi yang diajarkan", 4, "dosen menguasai materi perkuliahan dengan baik?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"));

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
        }
    }
}
