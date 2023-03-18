using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class StoreSectionAsString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Section",
                table: "Questions",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"),
                column: "Section",
                value: "kesempatan bertanya");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"),
                column: "Section",
                value: "kesempatan bertanya");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"),
                column: "Section",
                value: "penggunaan elearning");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"),
                column: "Section",
                value: "penggunaan elearning");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"),
                column: "Section",
                value: "penggunaan elearning");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"),
                column: "Section",
                value: "transparansi nilai");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"),
                column: "Section",
                value: "transparansi nilai");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"),
                column: "Section",
                value: "transparansi nilai");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"),
                column: "Section",
                value: "kedisiplinan waktu");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"),
                column: "Section",
                value: "kedisiplinan waktu");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"),
                column: "Section",
                value: "rencana kontrak kuliah");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"),
                column: "Section",
                value: "rencana kontrak kuliah");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"),
                column: "Section",
                value: "penguasaan materi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Section",
                table: "Questions",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"),
                column: "Section",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"),
                column: "Section",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"),
                column: "Section",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"),
                column: "Section",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"),
                column: "Section",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"),
                column: "Section",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"),
                column: "Section",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"),
                column: "Section",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"),
                column: "Section",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"),
                column: "Section",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"),
                column: "Section",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"),
                column: "Section",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"),
                column: "Section",
                value: 4);
        }
    }
}
