using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class SeedLecturers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
