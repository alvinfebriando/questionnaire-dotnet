using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class FixInvalidGuidInZod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("05af1284-ad61-4390-7a7f-3535a44e5cf2"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("05b59c1b-3e4c-ab0c-9ff4-f5de46dd4301"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("0b2a8e9a-d145-2819-934e-8284a9379b20"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("26a57d9e-4384-5556-9d48-d66f4336a0f3"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("30f584b3-55a8-f321-4ebc-54009ca3ede7"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("77ecf855-c066-d894-fa84-6291fb72758d"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("7b949f5a-bac5-a63c-e2ec-c5ac5796cb71"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("815d3c03-0bd8-b7c8-cbb5-b836712833ea"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("82c6ef09-fb77-5914-fbda-1b75a985ba9b"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("8ab00ac7-aafc-b129-f9eb-f50414aec109"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("903be25c-48df-026b-d729-e49700f58528"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("921ebaf8-ee44-67bd-64ea-951be3b1d75e"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("a0ae28eb-f0d5-face-c4dd-78ce871f5b4d"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("a24f69a5-1ed7-1825-428e-6b509b9d34af"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("add0a207-50f4-9241-4ceb-1d043f4ca29f"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("b05f136f-c1a4-e0fc-0429-e7ce51d56a47"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("b0dbfe4b-95f0-4991-8296-1169d97f44bb"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("ba79f59c-8e11-8f9c-07d8-b5ec0cdf58b3"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("bd81a51f-8fe9-862e-ae91-06edf6e7667a"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("c613831a-807e-488d-d760-e83f6e112401"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("cbb94705-d940-5123-feef-17ce9396e5ef"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("cdcf3688-7912-5d3d-51eb-491207af0f5e"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("cec54a15-b251-d2a1-495f-ab49784481ea"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("cf085f5c-eb78-c6b8-9cc5-0013a505c6e4"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("d58c20be-1db2-61d5-8113-400924b3bb1e"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("eb419414-99ff-2431-33b4-08a440a86040"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("f4f76bbe-6c08-e239-c3d0-a31f73fe7f8d"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("f6d145b6-1df0-7aff-07ce-3c34834febf6"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("f704ea12-9ed3-0f1f-6339-3aa54f93e70a"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("feb9f927-2ae8-c960-06b0-72b1822917ad"));

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Name", "Title" },
                values: new object[,]
                {
                    { new Guid("0691c1a9-5587-4425-b312-3dae4921a713"), "Jamalia", "Bu" },
                    { new Guid("24c54838-005f-4676-b033-a220a2eebd93"), "Rahmi", "Bu" },
                    { new Guid("2876cc93-03c2-4cfd-b3d1-97ebb8d1e01d"), "Cengkir", "Pak" },
                    { new Guid("3159cfc5-2ebb-4640-8dd6-968df57bce94"), "Cahyo", "Pak" },
                    { new Guid("31d07541-32c4-41a2-baa5-946c9fad43d1"), "Enteng", "Pak" },
                    { new Guid("3b0e6594-0a27-46c7-a809-a3bec05042eb"), "Fathonah", "Bu" },
                    { new Guid("3daa1662-43bf-42c8-9188-3f82342c194b"), "Okto", "Pak" },
                    { new Guid("43d9ce94-281c-4669-963f-216384f80c6b"), "Diana", "Bu" },
                    { new Guid("4aa23e34-bb92-4d0e-8466-7f0384177deb"), "Zamira", "Bu" },
                    { new Guid("4bf9cde4-386c-4b93-84b6-1c2a6b9baadd"), "Opan", "Pak" },
                    { new Guid("4e1dafb0-9b03-4a72-bba8-485974c27da7"), "Xanana", "Pak" },
                    { new Guid("5f3c7eb4-6c20-48c9-a63d-6212562b0044"), "Viman", "Pak" },
                    { new Guid("657e4ff3-32c0-4a50-9428-c715abae675c"), "Cinthia", "Bu" },
                    { new Guid("66123d84-ac2a-4fe6-b9f1-02b0e27d510b"), "Mila", "Bu" },
                    { new Guid("71ae0e18-95d6-46da-883c-9693b06215c9"), "Ajimat", "Pak" },
                    { new Guid("72be6dc2-b393-4764-a709-448c5d9f3e2e"), "Widya", "Bu" },
                    { new Guid("88027b9e-fb69-482f-9785-6e00d4ea003d"), "Tasdik", "Pak" },
                    { new Guid("95850737-7c11-4edc-b3c4-0a60192bea09"), "Rini", "Bu" },
                    { new Guid("99b0a931-4309-4a68-8644-6e8ca111ab05"), "Ira", "Bu" },
                    { new Guid("a5edd7a0-d972-4010-913b-3dc33c571a28"), "Praba", "Pak" },
                    { new Guid("aac8b5bb-f458-4261-86e3-0196b434e94f"), "Zamira", "Bu" },
                    { new Guid("bc89c5c4-2a0e-4a76-9afe-483cb114e2fe"), "Mahmud", "Pak" },
                    { new Guid("c7298bae-a27e-4fcd-9860-88126d0e2cc3"), "Nalar", "Pak" },
                    { new Guid("c8e7d4ff-be7d-4967-8a09-d5d53ee2ad7b"), "Jasmani", "Pak" },
                    { new Guid("cae206a7-2523-424e-a323-bcba266b3025"), "Salwa", "Bu" },
                    { new Guid("d5abbaea-6de1-407d-9caa-46bb341c093c"), "Gantar", "Pak" },
                    { new Guid("d6ccde9c-908b-46b6-bc44-8aabc2193c44"), "Paris", "Bu" },
                    { new Guid("dccbdb0b-e446-4053-bcfe-420c278ad044"), "Fitria", "Bu" },
                    { new Guid("ea431a62-01f4-4c28-9951-4bec9a6ee1b8"), "Karja", "Pak" },
                    { new Guid("f04bd3d8-e2ca-43d9-a59a-de817885fefe"), "Ade", "Bu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("0691c1a9-5587-4425-b312-3dae4921a713"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("24c54838-005f-4676-b033-a220a2eebd93"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("2876cc93-03c2-4cfd-b3d1-97ebb8d1e01d"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("3159cfc5-2ebb-4640-8dd6-968df57bce94"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("31d07541-32c4-41a2-baa5-946c9fad43d1"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("3b0e6594-0a27-46c7-a809-a3bec05042eb"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("3daa1662-43bf-42c8-9188-3f82342c194b"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("43d9ce94-281c-4669-963f-216384f80c6b"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("4aa23e34-bb92-4d0e-8466-7f0384177deb"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("4bf9cde4-386c-4b93-84b6-1c2a6b9baadd"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("4e1dafb0-9b03-4a72-bba8-485974c27da7"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("5f3c7eb4-6c20-48c9-a63d-6212562b0044"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("657e4ff3-32c0-4a50-9428-c715abae675c"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("66123d84-ac2a-4fe6-b9f1-02b0e27d510b"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("71ae0e18-95d6-46da-883c-9693b06215c9"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("72be6dc2-b393-4764-a709-448c5d9f3e2e"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("88027b9e-fb69-482f-9785-6e00d4ea003d"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("95850737-7c11-4edc-b3c4-0a60192bea09"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("99b0a931-4309-4a68-8644-6e8ca111ab05"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("a5edd7a0-d972-4010-913b-3dc33c571a28"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("aac8b5bb-f458-4261-86e3-0196b434e94f"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("bc89c5c4-2a0e-4a76-9afe-483cb114e2fe"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("c7298bae-a27e-4fcd-9860-88126d0e2cc3"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("c8e7d4ff-be7d-4967-8a09-d5d53ee2ad7b"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("cae206a7-2523-424e-a323-bcba266b3025"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("d5abbaea-6de1-407d-9caa-46bb341c093c"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("d6ccde9c-908b-46b6-bc44-8aabc2193c44"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("dccbdb0b-e446-4053-bcfe-420c278ad044"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("ea431a62-01f4-4c28-9951-4bec9a6ee1b8"));

            migrationBuilder.DeleteData(
                table: "Lecturers",
                keyColumn: "Id",
                keyValue: new Guid("f04bd3d8-e2ca-43d9-a59a-de817885fefe"));

            migrationBuilder.InsertData(
                table: "Lecturers",
                columns: new[] { "Id", "Name", "Title" },
                values: new object[,]
                {
                    { new Guid("05af1284-ad61-4390-7a7f-3535a44e5cf2"), "Bajragin", "Pak" },
                    { new Guid("05b59c1b-3e4c-ab0c-9ff4-f5de46dd4301"), "Cawisadi", "Pak" },
                    { new Guid("0b2a8e9a-d145-2819-934e-8284a9379b20"), "Kiandra", "Bu" },
                    { new Guid("26a57d9e-4384-5556-9d48-d66f4336a0f3"), "Maria", "Bu" },
                    { new Guid("30f584b3-55a8-f321-4ebc-54009ca3ede7"), "Zamira", "Bu" },
                    { new Guid("77ecf855-c066-d894-fa84-6291fb72758d"), "Lalita", "Bu" },
                    { new Guid("7b949f5a-bac5-a63c-e2ec-c5ac5796cb71"), "Perkasa", "Pak" },
                    { new Guid("815d3c03-0bd8-b7c8-cbb5-b836712833ea"), "Sakura", "Bu" },
                    { new Guid("82c6ef09-fb77-5914-fbda-1b75a985ba9b"), "Nova", "Bu" },
                    { new Guid("8ab00ac7-aafc-b129-f9eb-f50414aec109"), "Elma", "Bu" },
                    { new Guid("903be25c-48df-026b-d729-e49700f58528"), "Ilsa", "Bu" },
                    { new Guid("921ebaf8-ee44-67bd-64ea-951be3b1d75e"), "Puput", "Bu" },
                    { new Guid("a0ae28eb-f0d5-face-c4dd-78ce871f5b4d"), "Cahyo", "Pak" },
                    { new Guid("a24f69a5-1ed7-1825-428e-6b509b9d34af"), "Maras", "Pak" },
                    { new Guid("add0a207-50f4-9241-4ceb-1d043f4ca29f"), "Akarsana", "Pak" },
                    { new Guid("b05f136f-c1a4-e0fc-0429-e7ce51d56a47"), "Cinta", "Bu" },
                    { new Guid("b0dbfe4b-95f0-4991-8296-1169d97f44bb"), "Prayitna", "Pak" },
                    { new Guid("ba79f59c-8e11-8f9c-07d8-b5ec0cdf58b3"), "Hesti", "Bu" },
                    { new Guid("bd81a51f-8fe9-862e-ae91-06edf6e7667a"), "Ulva", "Bu" },
                    { new Guid("c613831a-807e-488d-d760-e83f6e112401"), "Dimas", "Pak" },
                    { new Guid("cbb94705-d940-5123-feef-17ce9396e5ef"), "Farah", "Bu" },
                    { new Guid("cdcf3688-7912-5d3d-51eb-491207af0f5e"), "Upik", "Pak" },
                    { new Guid("cec54a15-b251-d2a1-495f-ab49784481ea"), "Rachel", "Bu" },
                    { new Guid("cf085f5c-eb78-c6b8-9cc5-0013a505c6e4"), "Maya", "Bu" },
                    { new Guid("d58c20be-1db2-61d5-8113-400924b3bb1e"), "Ade", "Bu" },
                    { new Guid("eb419414-99ff-2431-33b4-08a440a86040"), "Jane", "Bu" },
                    { new Guid("f4f76bbe-6c08-e239-c3d0-a31f73fe7f8d"), "Galur", "Pak" },
                    { new Guid("f6d145b6-1df0-7aff-07ce-3c34834febf6"), "Prima", "Pak" },
                    { new Guid("f704ea12-9ed3-0f1f-6339-3aa54f93e70a"), "Ami", "Bu" },
                    { new Guid("feb9f927-2ae8-c960-06b0-72b1822917ad"), "Ikhsan", "Pak" }
                });
        }
    }
}
