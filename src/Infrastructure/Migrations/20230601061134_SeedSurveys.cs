using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class SeedSurveys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "AspectCount", "Date", "LecturerId", "Place", "QuestionCount", "Subject" },
                values: new object[,]
                {
                    { new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1"), 6, new DateOnly(2023, 5, 15), new Guid("57ab1244-8484-4b48-9ccf-ccb0ffb21166"), "B", 13, "Manajemen Proyek Teknologi Informasi" },
                    { new Guid("28cf256d-db33-a30a-32d9-354ae98b858f"), 6, new DateOnly(2023, 3, 31), new Guid("a100dea5-b5ec-431e-b2b4-127bc58e19c1"), "B", 13, "Matematika Diskrit" },
                    { new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c"), 6, new DateOnly(2023, 5, 17), new Guid("f05e1bf1-768c-4719-8a78-b68ba477d010"), "C", 13, "Pemrograman Integrative" },
                    { new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a"), 6, new DateOnly(2023, 4, 2), new Guid("47ddf172-2abb-4e77-83ca-0b52ab5a4bed"), "C", 13, "Pendidikan Agama Budha" },
                    { new Guid("81b90884-1f29-260c-698e-195c79400f60"), 6, new DateOnly(2023, 5, 8), new Guid("47ddf172-2abb-4e77-83ca-0b52ab5a4bed"), "B", 13, "Matematika Diskrit" },
                    { new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d"), 6, new DateOnly(2023, 3, 24), new Guid("3a42af84-9f31-4d8a-a0f0-b9ee2f563639"), "B", 13, "Pemrograman Integrative" },
                    { new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb"), 6, new DateOnly(2023, 5, 10), new Guid("5c7dfd25-206b-4f80-9876-15ad64a6afb6"), "C", 13, "Pendidikan Agama Konghucu" },
                    { new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699"), 6, new DateOnly(2023, 3, 26), new Guid("fa1b6693-4f1c-4cd5-98c2-024d6fa6be19"), "C", 13, "Desain Interaksi" },
                    { new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56"), 6, new DateOnly(2023, 5, 13), new Guid("a18dcd39-1de8-4b93-a237-8936c3f1f0a0"), "A", 13, "Dasar Pemrograman" },
                    { new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514"), 6, new DateOnly(2023, 3, 28), new Guid("3c16908e-ace6-430d-b360-d63c2032dbcc"), "A", 13, "Jaminan dan Keamanan Informasi" }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestions",
                columns: new[] { "QuestionId", "SurveyId" },
                values: new object[,]
                {
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("81b90884-1f29-260c-698e-195c79400f60") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") },
                    { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") },
                    { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("28cf256d-db33-a30a-32d9-354ae98b858f") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("81b90884-1f29-260c-698e-195c79400f60") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("218408d9-5277-4a87-85b0-49e4d58f562e"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("2345f1b9-68ea-47c0-a07c-308c96bb57f9"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("26a20919-c2a6-4d55-ba27-d1c9e7494803"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("5eaade91-6711-40f4-bc93-865c1f236e9f"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("92629cf6-7fe4-44fc-886e-96dc9fe7e46d"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b242aabb-2a9b-4f6e-b5b2-c3f599ca307e"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("b69bc16e-ae97-471c-80db-6ef12b26638c"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("c8d17dd4-ee70-4ab8-87d4-b5fff5b21e72"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("d7434e14-1b4e-4d05-bc24-17c1fe75f4b9"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dade9ae9-02b1-410c-9048-da7ed520c459"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("dfddc352-89d5-40dc-a428-1cccd3bb1925"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("f0b09e3c-87d1-4c8a-9408-cb9ee5881552"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumns: new[] { "QuestionId", "SurveyId" },
                keyValues: new object[] { new Guid("fa5a6ef2-b376-4122-9f1e-591a29e1a2de"), new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514") });

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("10a7d7de-527b-91c1-5fa9-7a71905cbdd1"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("28cf256d-db33-a30a-32d9-354ae98b858f"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("3ff772fc-64ec-b453-0608-ef2343ba4c4c"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("571fbf8b-eca4-c69c-da37-aafc9cea140a"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("81b90884-1f29-260c-698e-195c79400f60"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("99e15513-a7e1-3855-3cbd-d434d26fd71d"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("b008a2a2-3099-4a9e-10ec-8f0d2b9e9fdb"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("c830ef31-b952-5be6-e41b-4ae684ce6699"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("e0583dc0-410a-6d2f-b74b-04bfdefd2e56"));

            migrationBuilder.DeleteData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: new Guid("f8808a4f-cac3-7f78-8b7a-bf98372cf514"));
        }
    }
}
