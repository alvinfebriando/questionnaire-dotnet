using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class LowercaseUserPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0268300b-541a-8f24-bd8b-ce7583da35e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("047d95ca-7507-ff36-eb22-692ed4723ccf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04ac69e0-af89-e9be-a9a3-b69e103309c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0cdce519-a962-8595-ecc9-74559f675504"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d2e94d7-8a59-9c98-1edc-ae4bb95330f0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11752492-3634-571e-112d-721a33ff1f2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11abe0b2-87b0-3bc0-fb38-13bfe034f5c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bba6d5e-945b-d883-5aa6-4701da8f2a7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e02616b-663d-1e6c-9ccb-177258ee759f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e5b90f3-f418-31ad-3f5e-ce32873b6a7e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e9ecb9a-d577-95f9-4679-14160c6f56ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1fd1eeb2-f67c-856d-a059-6fcb7d9c0090"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("225d34e1-d92b-9732-8e80-fe7b6ec2dbf4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("242d7502-d49e-12d6-6370-915e2a4707b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("258f6470-9424-73a9-d71d-ad9bb94c1743"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2995aea4-4c58-d927-b8b2-384aa009d2c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2baa9291-e792-c3c5-c53d-51c8a3da0aec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2c3a3125-62e1-cb70-c046-3cdb64eb6d36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2ce3192e-42cd-23c0-a345-fb359094fe4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2d04cb84-a961-97a3-8fbf-fa0e734af9fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("30f149e6-b2cd-bf6a-3bda-0423abfd03b3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("318c0df3-9670-be84-7109-3e454f9d0609"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("34d44e91-152a-dbb1-8529-26056b8926da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c6f2ece-3d05-6cd4-a952-2a010c89b116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d670304-d131-d70b-761c-dbebf2fe56bb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e2d4b50-d4f6-acb7-8da4-0690416f030f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40b14aec-a835-7143-9db1-69c954054357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40f76385-ce54-2419-0dd6-e80c75b40255"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4116a048-f490-6158-94b9-acf00286c815"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("42cd424d-983d-9cc2-d8cc-86474594ad68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("454abf84-f70e-78f0-77a1-f452012e7ad5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49e9317e-aa57-4ca9-fd3a-acc88eb84c0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fb224db-6c57-6f9e-83db-1ebf14ba09fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5472b5a1-2113-8164-a1e7-cfe22e0e5930"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("592b5b3c-c9af-9595-ebfc-31fc8e0997ee"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b594793-6abc-f91a-8198-7a55700dea74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5dd6a668-5796-4ec7-e8dd-5e9c817abb61"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69fc612d-ad16-7d86-7b92-29915dc8ce22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6b7e3d78-68dc-0741-de7f-ac91f25ff9b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c82e5e9-e137-3935-cfc3-7b5842307d5c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6db71b47-7d72-b4b7-de83-51d1fb38af48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("728014a7-9978-044d-d68c-a10a1be93e40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("74650f07-e324-98e6-d845-4fb7ff88b492"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7938f5a0-37d0-3e25-756f-cf4a36548740"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79dec5a5-65a0-7220-ff08-6f9c17c55467"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7c961a8f-0ce1-e2f6-43d6-f91668db9975"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d052ae8-6ddf-c9b9-5cae-ee05d6244439"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fe68ec2-1a36-e6fa-a34a-8db8b0c01344"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fea28c5-7116-26af-3fdf-5a2f2f5a9e5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ffe055a-cd5b-c51c-eb05-ecf633028248"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("803e1e6b-24ed-9380-d9ea-7ffa3747c54e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("889d7d38-b143-8f35-124f-344b705bfb42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c3f8d6a-5105-4ce9-74b2-648ee8e8c390"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("908aa701-4f90-f5c6-4eb1-e2d06d6f3e25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("92a0a7b3-a58a-5048-fd60-860d9f0df349"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("965d0089-94f0-39b5-243c-9fc74dcb8697"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("965f6fa8-8e3f-adce-fa72-37a1ff8a6ddd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9694735a-f2c4-70a8-f1e1-d50aab2d3e9e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9936f8d0-7777-f233-ba9d-d15103408558"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99bdd58d-2d19-8843-324d-aa1016bdcb45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b34714c-3056-70fb-da2d-a9bef3e63bde"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9f6a1773-ea51-0396-421a-b14007ce52f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a089d177-8469-6c87-f5c4-93978ae11e52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a2a88a81-a317-43ab-b0c6-d0ea0394a301"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4ee2d9a-0862-bf55-29e3-57c873b1039d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a7fe81cd-1351-bbf6-8788-4f2b6743c6f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a95ee212-0137-fc15-8667-28778d6fd3a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b0686d9e-2541-0793-cd06-7ee6187fbc47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b704417f-dd98-f4e5-9fc4-ef4accae5c72"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b763165f-945d-8615-50c1-64e3d647f93f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8e9f070-9e7c-cfa4-fc4b-0ceffe79a5e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfb472c4-3b4f-7734-cd88-1ccc076311a4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0749111-f02e-9b07-1de0-ebb66c962088"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3249cce-6b50-a9ba-973e-5a2edd54c371"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c58ffb89-bbef-995f-c144-9f733458cf8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5966cf9-e974-8a95-4bbf-55c55e8a92e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5d247a4-7c22-d264-1d83-f75c31dcfb54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd196e5d-4ddf-0f42-de55-6aaca5e69d52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cd4474c7-eb1a-d04a-7fe9-8cf5563521de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cdd1c450-19d9-b9e5-e4f9-05fbfa3bc8ec"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbd7e894-7bdc-9b88-eeb1-475944d6a10f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dbea875c-7dd7-64dc-2045-231b2c42ea83"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc054298-0ccc-2bae-9089-ea910cb10f94"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc9997bd-7b40-0be6-d4df-de69fcd006d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd83b458-b487-9311-23a9-4bd7e28c540e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e534f6d4-2be8-1a5c-18ed-754f43766a03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e59a1db9-be4b-010e-db2a-b6ba388af454"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8b1bc82-79ab-b83e-da25-3d287e2b6580"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e98ce00a-1469-337b-45d7-7e97d33badfc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f15c59b5-358a-36a9-c029-35988f28c667"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f3e4594b-1813-112a-bc70-5f902fcb40a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f610ae12-7b56-1f91-0440-700986e77189"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fa1e3a71-9f8a-8536-0286-5f4e70e06d45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc38688c-64de-a99f-b877-58cbdd60390a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fcce2c0a-c0f4-f832-0dcd-33a91e8ca2ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fddd85a6-e6b1-0437-d35c-4975caf69093"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("febb6914-52d7-1ef6-f010-b07e8141b0d2"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("02d2e5fe-f30a-49b8-2a07-c1ffbb66568d"), "eka@usu.ac.id", "Eka", "eka123" },
                    { new Guid("041e6e7c-c9d1-e3b8-9787-21008b5a9a07"), "putri@usu.ac.id", "Putri", "putri123" },
                    { new Guid("055d0078-98f9-29fc-8cd5-714352c801a0"), "vivi@usu.ac.id", "Vivi", "vivi123" },
                    { new Guid("099df9bc-9e24-7aa4-6b58-d49d76f42826"), "dipa@usu.ac.id", "Dipa", "dipa123" },
                    { new Guid("0a3334cb-e92e-93e5-a005-a994ec4eecf9"), "anita@usu.ac.id", "Anita", "anita123" },
                    { new Guid("0b965591-a0dd-e4a2-da95-49e0f4f8ed8b"), "kasusra@usu.ac.id", "Kasusra", "kasusra123" },
                    { new Guid("0b994793-cfd6-8adf-9933-3e064698188e"), "unjani@usu.ac.id", "Unjani", "unjani123" },
                    { new Guid("0ea949e4-ceb6-ba29-70b3-ff18e484363b"), "putu@usu.ac.id", "Putu", "putu123" },
                    { new Guid("0f7a07e4-7ea8-0cff-d46f-ccda2dfd21bc"), "wisnu@usu.ac.id", "Wisnu", "wisnu123" },
                    { new Guid("112a5cad-4c58-f898-d321-ef27141e6b09"), "cinthia@usu.ac.id", "Cinthia", "cinthia123" },
                    { new Guid("14e21d6e-e54d-020b-b4c5-4bdd1329e74d"), "faizah@usu.ac.id", "Faizah", "faizah123" },
                    { new Guid("177706b8-b9b1-3ec9-53ab-2cec6d665be6"), "martaka@usu.ac.id", "Martaka", "martaka123" },
                    { new Guid("17a8c2b2-9ce1-413d-7d3a-26d2d4f17ab0"), "titin@usu.ac.id", "Titin", "titin123" },
                    { new Guid("1b2d537b-b26f-4636-a5bb-7148c79cadef"), "muhammad@usu.ac.id", "Muhammad", "muhammad123" },
                    { new Guid("1d8aa52f-d01c-4e00-51e7-7e4aee00ab0f"), "martana@usu.ac.id", "Martana", "martana123" },
                    { new Guid("1e894e0b-f854-2795-2278-1dd72358358b"), "usyi@usu.ac.id", "Usyi", "usyi123" },
                    { new Guid("21c18bfb-3214-5d4c-4f02-f8d6943b8d25"), "bakidin@usu.ac.id", "Bakidin", "bakidin123" },
                    { new Guid("242fc5a7-154b-52ca-93e4-156ed97cb365"), "gabriella@usu.ac.id", "Gabriella", "gabriella123" },
                    { new Guid("2fd37a11-e8a0-b5c1-e9f2-0a4632ce1ba3"), "samsul@usu.ac.id", "Samsul", "samsul123" },
                    { new Guid("3180027d-4782-cd46-2c4f-bb6273891b5f"), "cengkir@usu.ac.id", "Cengkir", "cengkir123" },
                    { new Guid("31ba9229-7054-fcb6-636f-4eda2cb5c45c"), "rosman@usu.ac.id", "Rosman", "rosman123" },
                    { new Guid("3280b0b0-a7bc-0b9b-546e-96600a8940ef"), "bagya@usu.ac.id", "Bagya", "bagya123" },
                    { new Guid("3696f657-44fa-45ca-1c40-5802d157a43c"), "puspa@usu.ac.id", "Puspa", "puspa123" },
                    { new Guid("376ed614-4382-007f-4b11-99650f83928b"), "tina@usu.ac.id", "Tina", "tina123" },
                    { new Guid("3900fa02-4322-045c-dab2-982257054947"), "jagaraga@usu.ac.id", "Jagaraga", "jagaraga123" },
                    { new Guid("391bd872-52df-8e20-4ff1-723208248b42"), "gara@usu.ac.id", "Gara", "gara123" },
                    { new Guid("3d8af3d9-6213-bd6b-4efb-ee36145f725a"), "nadia@usu.ac.id", "Nadia", "nadia123" },
                    { new Guid("3e8a10f5-ace6-0d9f-8c4a-2ca5432ba309"), "kariman@usu.ac.id", "Kariman", "kariman123" },
                    { new Guid("3ebbc9bf-a81e-f715-e88b-80d0ff13f8a9"), "jaswadi@usu.ac.id", "Jaswadi", "jaswadi123" },
                    { new Guid("40cbcac1-d4be-4d8a-ff12-12e2cbba8e08"), "martaka@usu.ac.id", "Martaka", "martaka123" },
                    { new Guid("4210ce2e-6d8c-ee55-fe7f-9b5f663fee6c"), "uli@usu.ac.id", "Uli", "uli123" },
                    { new Guid("426702aa-9961-3f8b-9368-6b089365f1fd"), "ciaobella@usu.ac.id", "Ciaobella", "ciaobella123" },
                    { new Guid("4e34df7b-5dca-4298-344a-fb9187e5f731"), "balamantri@usu.ac.id", "Balamantri", "balamantri123" },
                    { new Guid("4fd1c096-cb21-aedb-d6f1-583d6bcfbe53"), "tiara@usu.ac.id", "Tiara", "tiara123" },
                    { new Guid("534caef9-11ca-0cda-19ab-90ede322338f"), "jagaraga@usu.ac.id", "Jagaraga", "jagaraga123" },
                    { new Guid("5717ae4b-bee7-440b-48f0-c9a616f01de6"), "ina@usu.ac.id", "Ina", "ina123" },
                    { new Guid("5a533a0c-98cb-c560-3de7-162cc5394a59"), "cinthia@usu.ac.id", "Cinthia", "cinthia123" },
                    { new Guid("5b4f362d-61a4-a776-9b3a-a04bd14ef6f4"), "gawati@usu.ac.id", "Gawati", "gawati123" },
                    { new Guid("606de120-f908-b10f-254b-cc1e0543ce5d"), "bajragin@usu.ac.id", "Bajragin", "bajragin123" },
                    { new Guid("6124c361-15bd-8d87-74d9-3ad184ed2692"), "nabila@usu.ac.id", "Nabila", "nabila123" },
                    { new Guid("6151d401-41e0-0675-c582-69b0715a3bdf"), "salsabila@usu.ac.id", "Salsabila", "salsabila123" },
                    { new Guid("63bca3af-04a1-2376-5bf7-05f9d055e003"), "puput@usu.ac.id", "Puput", "puput123" },
                    { new Guid("6c4f1819-0244-985a-467e-1a390c1321e3"), "martaka@usu.ac.id", "Martaka", "martaka123" },
                    { new Guid("6f3c3e4a-bf1f-0cd6-2a3d-9a572102da6c"), "faizah@usu.ac.id", "Faizah", "faizah123" },
                    { new Guid("749cfa0e-fa1d-d2fe-55c8-f2e299a663c5"), "ilsa@usu.ac.id", "Ilsa", "ilsa123" },
                    { new Guid("7a11064b-1c54-1f26-e98b-e88a9ccf7f02"), "baktianto@usu.ac.id", "Baktianto", "baktianto123" },
                    { new Guid("7ca088f5-f876-f656-4499-9dc53f77f3fe"), "jane@usu.ac.id", "Jane", "jane123" },
                    { new Guid("7d09be6c-45ad-7798-58b7-9d79f7b6e7c5"), "tugiman@usu.ac.id", "Tugiman", "tugiman123" },
                    { new Guid("7f9bc449-4656-22a9-b28a-4f9a7df330d3"), "yulia@usu.ac.id", "Yulia", "yulia123" },
                    { new Guid("80152164-c797-8d7a-3b87-0b4853ac4313"), "baktiono@usu.ac.id", "Baktiono", "baktiono123" },
                    { new Guid("83233fa5-8445-1a7c-0c29-3a793430567b"), "daliman@usu.ac.id", "Daliman", "daliman123" },
                    { new Guid("854a01fa-bd1a-d5d9-c528-ecc376c110a8"), "puji@usu.ac.id", "Puji", "puji123" },
                    { new Guid("893ced23-516a-942b-b696-b812d7adc5c5"), "wulan@usu.ac.id", "Wulan", "wulan123" },
                    { new Guid("8ab54453-ec46-7340-e66f-afde9137ca0a"), "kuncara@usu.ac.id", "Kuncara", "kuncara123" },
                    { new Guid("928f2854-be38-5226-da7f-ed8f3a3c6dc8"), "margana@usu.ac.id", "Margana", "margana123" },
                    { new Guid("98c50108-f03a-a3ac-5482-1dd46f913ecf"), "kawaya@usu.ac.id", "Kawaya", "kawaya123" },
                    { new Guid("9ad21dd4-0dc6-212f-3647-02b69214c34e"), "surya@usu.ac.id", "Surya", "surya123" },
                    { new Guid("9ee668a7-31ad-bbd1-c845-c62a0dc5550e"), "hamzah@usu.ac.id", "Hamzah", "hamzah123" },
                    { new Guid("a63371c1-19ef-9840-a293-017e5489e471"), "ridwan@usu.ac.id", "Ridwan", "ridwan123" },
                    { new Guid("ac29b6c4-7ba6-874d-154e-7a97a8a7fadc"), "carub@usu.ac.id", "Carub", "carub123" },
                    { new Guid("ac4f48d7-7f15-0755-3854-efbbde58f2af"), "hamima@usu.ac.id", "Hamima", "hamima123" },
                    { new Guid("acc7b522-cc9f-1832-6ad9-437dc931ab13"), "keisha@usu.ac.id", "Keisha", "keisha123" },
                    { new Guid("af19fb59-b9f0-4393-bf68-3501c92faa84"), "bakiman@usu.ac.id", "Bakiman", "bakiman123" },
                    { new Guid("b24aa6bf-fcb6-423d-2dd3-21c1f57c6218"), "bakti@usu.ac.id", "Bakti", "bakti123" },
                    { new Guid("b2f2fe42-f58c-1b99-2f18-97378f6402bf"), "daruna@usu.ac.id", "Daruna", "daruna123" },
                    { new Guid("b3357877-b474-ab6d-f270-95ac5d3e9234"), "paulin@usu.ac.id", "Paulin", "paulin123" },
                    { new Guid("b729da39-c386-5fb1-c5d6-47543717fb34"), "bella@usu.ac.id", "Bella", "bella123" },
                    { new Guid("bd7ef19b-8b2e-57e9-b3f6-95dc917f3247"), "endah@usu.ac.id", "Endah", "endah123" },
                    { new Guid("be7053f1-ee19-e1b1-3bed-c4b0ee5c1c96"), "sadina@usu.ac.id", "Sadina", "sadina123" },
                    { new Guid("beb97497-afa4-7c5f-8c43-840a177d8373"), "erik@usu.ac.id", "Erik", "erik123" },
                    { new Guid("c23498d8-d011-7a3e-b229-c45bf0d7f45f"), "tiara@usu.ac.id", "Tiara", "tiara123" },
                    { new Guid("c31da94c-cdef-f30a-46ed-45a1d3cf5572"), "soleh@usu.ac.id", "Soleh", "soleh123" },
                    { new Guid("c49782bb-c3c9-a79e-e909-5e92fbfd5d1c"), "bakda@usu.ac.id", "Bakda", "bakda123" },
                    { new Guid("c5e5f19f-a325-b546-e8f3-49f70ccc6766"), "eli@usu.ac.id", "Eli", "eli123" },
                    { new Guid("c71c2af3-23a7-cb90-4338-ab805a471131"), "harto@usu.ac.id", "Harto", "harto123" },
                    { new Guid("c8004462-5e5b-9608-f94c-6e81328fa8da"), "amalia@usu.ac.id", "Amalia", "amalia123" },
                    { new Guid("cc4bb1d9-f6ed-0bed-6af5-478b949ce593"), "wirda@usu.ac.id", "Wirda", "wirda123" },
                    { new Guid("ce0e6810-56f6-6873-978f-a9696e424f96"), "azalea@usu.ac.id", "Azalea", "azalea123" },
                    { new Guid("cf0a32c2-bd6d-933e-1ac9-3d34a272e597"), "empluk@usu.ac.id", "Empluk", "empluk123" },
                    { new Guid("cfc0ca26-680d-6862-ccf1-40baf5054b74"), "anom@usu.ac.id", "Anom", "anom123" },
                    { new Guid("cfcec852-015f-b28b-1015-9e87f08ec136"), "nabila@usu.ac.id", "Nabila", "nabila123" },
                    { new Guid("d1ac3a39-0dbb-1059-c1bc-257a9a5062d6"), "kania@usu.ac.id", "Kania", "kania123" },
                    { new Guid("d4259f7f-5241-d908-38ef-9eb6b5008e4b"), "devi@usu.ac.id", "Devi", "devi123" },
                    { new Guid("da0ebd6d-4d94-d9b4-84c6-76c14024a914"), "martani@usu.ac.id", "Martani", "martani123" },
                    { new Guid("dc5d4699-9e4e-61ab-fbb4-81bd28579621"), "unjani@usu.ac.id", "Unjani", "unjani123" },
                    { new Guid("e404ac81-31fe-8be6-ad44-b3c5b3a78355"), "vinsen@usu.ac.id", "Vinsen", "vinsen123" },
                    { new Guid("e4b4a5d4-9e60-46a9-f597-6ef569a7aecb"), "putri@usu.ac.id", "Putri", "putri123" },
                    { new Guid("e5f88e8f-7110-b772-9235-eda5b1dbd509"), "harsana@usu.ac.id", "Harsana", "harsana123" },
                    { new Guid("e6877feb-bc7d-935e-73ee-40436b772e06"), "nasrullah@usu.ac.id", "Nasrullah", "nasrullah123" },
                    { new Guid("e9fc9137-2df0-660b-3f47-07f47e3985da"), "prakosa@usu.ac.id", "Prakosa", "prakosa123" },
                    { new Guid("eab97f9a-3442-92e9-9024-73fdcb4ad275"), "kurnia@usu.ac.id", "Kurnia", "kurnia123" },
                    { new Guid("ec6603b1-29fd-0902-7a4d-b43a838fba58"), "rina@usu.ac.id", "Rina", "rina123" },
                    { new Guid("ed507dd9-5744-0d46-926e-c56010bc8b59"), "maimunah@usu.ac.id", "Maimunah", "maimunah123" },
                    { new Guid("ef816050-c1cc-fa20-db23-a30bda1d30a3"), "ilyas@usu.ac.id", "Ilyas", "ilyas123" },
                    { new Guid("f21d740a-18b7-ce3e-4551-e52ad5bf2b4a"), "bella@usu.ac.id", "Bella", "bella123" },
                    { new Guid("f235716c-8913-0624-8f23-07ba80272717"), "raden@usu.ac.id", "Raden", "raden123" },
                    { new Guid("f7d64bce-588a-4b72-89a2-0ad4d56d273b"), "harto@usu.ac.id", "Harto", "harto123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02d2e5fe-f30a-49b8-2a07-c1ffbb66568d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("041e6e7c-c9d1-e3b8-9787-21008b5a9a07"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("055d0078-98f9-29fc-8cd5-714352c801a0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("099df9bc-9e24-7aa4-6b58-d49d76f42826"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a3334cb-e92e-93e5-a005-a994ec4eecf9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b965591-a0dd-e4a2-da95-49e0f4f8ed8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0b994793-cfd6-8adf-9933-3e064698188e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0ea949e4-ceb6-ba29-70b3-ff18e484363b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f7a07e4-7ea8-0cff-d46f-ccda2dfd21bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("112a5cad-4c58-f898-d321-ef27141e6b09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14e21d6e-e54d-020b-b4c5-4bdd1329e74d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("177706b8-b9b1-3ec9-53ab-2cec6d665be6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17a8c2b2-9ce1-413d-7d3a-26d2d4f17ab0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b2d537b-b26f-4636-a5bb-7148c79cadef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1d8aa52f-d01c-4e00-51e7-7e4aee00ab0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e894e0b-f854-2795-2278-1dd72358358b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21c18bfb-3214-5d4c-4f02-f8d6943b8d25"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("242fc5a7-154b-52ca-93e4-156ed97cb365"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fd37a11-e8a0-b5c1-e9f2-0a4632ce1ba3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3180027d-4782-cd46-2c4f-bb6273891b5f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("31ba9229-7054-fcb6-636f-4eda2cb5c45c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3280b0b0-a7bc-0b9b-546e-96600a8940ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3696f657-44fa-45ca-1c40-5802d157a43c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("376ed614-4382-007f-4b11-99650f83928b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3900fa02-4322-045c-dab2-982257054947"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("391bd872-52df-8e20-4ff1-723208248b42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3d8af3d9-6213-bd6b-4efb-ee36145f725a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e8a10f5-ace6-0d9f-8c4a-2ca5432ba309"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ebbc9bf-a81e-f715-e88b-80d0ff13f8a9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40cbcac1-d4be-4d8a-ff12-12e2cbba8e08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4210ce2e-6d8c-ee55-fe7f-9b5f663fee6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("426702aa-9961-3f8b-9368-6b089365f1fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e34df7b-5dca-4298-344a-fb9187e5f731"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4fd1c096-cb21-aedb-d6f1-583d6bcfbe53"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("534caef9-11ca-0cda-19ab-90ede322338f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5717ae4b-bee7-440b-48f0-c9a616f01de6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a533a0c-98cb-c560-3de7-162cc5394a59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b4f362d-61a4-a776-9b3a-a04bd14ef6f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("606de120-f908-b10f-254b-cc1e0543ce5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6124c361-15bd-8d87-74d9-3ad184ed2692"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6151d401-41e0-0675-c582-69b0715a3bdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63bca3af-04a1-2376-5bf7-05f9d055e003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c4f1819-0244-985a-467e-1a390c1321e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f3c3e4a-bf1f-0cd6-2a3d-9a572102da6c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("749cfa0e-fa1d-d2fe-55c8-f2e299a663c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7a11064b-1c54-1f26-e98b-e88a9ccf7f02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ca088f5-f876-f656-4499-9dc53f77f3fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d09be6c-45ad-7798-58b7-9d79f7b6e7c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7f9bc449-4656-22a9-b28a-4f9a7df330d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80152164-c797-8d7a-3b87-0b4853ac4313"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83233fa5-8445-1a7c-0c29-3a793430567b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("854a01fa-bd1a-d5d9-c528-ecc376c110a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("893ced23-516a-942b-b696-b812d7adc5c5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8ab54453-ec46-7340-e66f-afde9137ca0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("928f2854-be38-5226-da7f-ed8f3a3c6dc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98c50108-f03a-a3ac-5482-1dd46f913ecf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ad21dd4-0dc6-212f-3647-02b69214c34e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ee668a7-31ad-bbd1-c845-c62a0dc5550e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a63371c1-19ef-9840-a293-017e5489e471"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac29b6c4-7ba6-874d-154e-7a97a8a7fadc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ac4f48d7-7f15-0755-3854-efbbde58f2af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("acc7b522-cc9f-1832-6ad9-437dc931ab13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af19fb59-b9f0-4393-bf68-3501c92faa84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b24aa6bf-fcb6-423d-2dd3-21c1f57c6218"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2f2fe42-f58c-1b99-2f18-97378f6402bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3357877-b474-ab6d-f270-95ac5d3e9234"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b729da39-c386-5fb1-c5d6-47543717fb34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd7ef19b-8b2e-57e9-b3f6-95dc917f3247"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("be7053f1-ee19-e1b1-3bed-c4b0ee5c1c96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("beb97497-afa4-7c5f-8c43-840a177d8373"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c23498d8-d011-7a3e-b229-c45bf0d7f45f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c31da94c-cdef-f30a-46ed-45a1d3cf5572"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c49782bb-c3c9-a79e-e909-5e92fbfd5d1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5e5f19f-a325-b546-e8f3-49f70ccc6766"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c71c2af3-23a7-cb90-4338-ab805a471131"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8004462-5e5b-9608-f94c-6e81328fa8da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc4bb1d9-f6ed-0bed-6af5-478b949ce593"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ce0e6810-56f6-6873-978f-a9696e424f96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cf0a32c2-bd6d-933e-1ac9-3d34a272e597"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfc0ca26-680d-6862-ccf1-40baf5054b74"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cfcec852-015f-b28b-1015-9e87f08ec136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d1ac3a39-0dbb-1059-c1bc-257a9a5062d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d4259f7f-5241-d908-38ef-9eb6b5008e4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da0ebd6d-4d94-d9b4-84c6-76c14024a914"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc5d4699-9e4e-61ab-fbb4-81bd28579621"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e404ac81-31fe-8be6-ad44-b3c5b3a78355"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4b4a5d4-9e60-46a9-f597-6ef569a7aecb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e5f88e8f-7110-b772-9235-eda5b1dbd509"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6877feb-bc7d-935e-73ee-40436b772e06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e9fc9137-2df0-660b-3f47-07f47e3985da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("eab97f9a-3442-92e9-9024-73fdcb4ad275"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec6603b1-29fd-0902-7a4d-b43a838fba58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed507dd9-5744-0d46-926e-c56010bc8b59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ef816050-c1cc-fa20-db23-a30bda1d30a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f21d740a-18b7-ce3e-4551-e52ad5bf2b4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f235716c-8913-0624-8f23-07ba80272717"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f7d64bce-588a-4b72-89a2-0ad4d56d273b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0268300b-541a-8f24-bd8b-ce7583da35e9"), "tirtayasa@usu.ac.id", "Tirtayasa", "Tirtayasa123" },
                    { new Guid("047d95ca-7507-ff36-eb22-692ed4723ccf"), "bakti@usu.ac.id", "Bakti", "Bakti123" },
                    { new Guid("04ac69e0-af89-e9be-a9a3-b69e103309c5"), "ana@usu.ac.id", "Ana", "Ana123" },
                    { new Guid("0cdce519-a962-8595-ecc9-74559f675504"), "wulan@usu.ac.id", "Wulan", "Wulan123" },
                    { new Guid("0d2e94d7-8a59-9c98-1edc-ae4bb95330f0"), "maria@usu.ac.id", "Maria", "Maria123" },
                    { new Guid("11752492-3634-571e-112d-721a33ff1f2e"), "gasti@usu.ac.id", "Gasti", "Gasti123" },
                    { new Guid("11abe0b2-87b0-3bc0-fb38-13bfe034f5c8"), "asirwada@usu.ac.id", "Asirwada", "Asirwada123" },
                    { new Guid("1bba6d5e-945b-d883-5aa6-4701da8f2a7a"), "sadina@usu.ac.id", "Sadina", "Sadina123" },
                    { new Guid("1e02616b-663d-1e6c-9ccb-177258ee759f"), "kurnia@usu.ac.id", "Kurnia", "Kurnia123" },
                    { new Guid("1e5b90f3-f418-31ad-3f5e-ce32873b6a7e"), "dewi@usu.ac.id", "Dewi", "Dewi123" },
                    { new Guid("1e9ecb9a-d577-95f9-4679-14160c6f56ee"), "banawa@usu.ac.id", "Banawa", "Banawa123" },
                    { new Guid("1fd1eeb2-f67c-856d-a059-6fcb7d9c0090"), "talia@usu.ac.id", "Talia", "Talia123" },
                    { new Guid("225d34e1-d92b-9732-8e80-fe7b6ec2dbf4"), "yono@usu.ac.id", "Yono", "Yono123" },
                    { new Guid("242d7502-d49e-12d6-6370-915e2a4707b7"), "jati@usu.ac.id", "Jati", "Jati123" },
                    { new Guid("258f6470-9424-73a9-d71d-ad9bb94c1743"), "balapati@usu.ac.id", "Balapati", "Balapati123" },
                    { new Guid("2995aea4-4c58-d927-b8b2-384aa009d2c8"), "margana@usu.ac.id", "Margana", "Margana123" },
                    { new Guid("2baa9291-e792-c3c5-c53d-51c8a3da0aec"), "julia@usu.ac.id", "Julia", "Julia123" },
                    { new Guid("2c3a3125-62e1-cb70-c046-3cdb64eb6d36"), "umay@usu.ac.id", "Umay", "Umay123" },
                    { new Guid("2ce3192e-42cd-23c0-a345-fb359094fe4b"), "gilda@usu.ac.id", "Gilda", "Gilda123" },
                    { new Guid("2d04cb84-a961-97a3-8fbf-fa0e734af9fe"), "dian@usu.ac.id", "Dian", "Dian123" },
                    { new Guid("30f149e6-b2cd-bf6a-3bda-0423abfd03b3"), "agnes@usu.ac.id", "Agnes", "Agnes123" },
                    { new Guid("318c0df3-9670-be84-7109-3e454f9d0609"), "devi@usu.ac.id", "Devi", "Devi123" },
                    { new Guid("34d44e91-152a-dbb1-8529-26056b8926da"), "gatot@usu.ac.id", "Gatot", "Gatot123" },
                    { new Guid("3c6f2ece-3d05-6cd4-a952-2a010c89b116"), "jelita@usu.ac.id", "Jelita", "Jelita123" },
                    { new Guid("3d670304-d131-d70b-761c-dbebf2fe56bb"), "xanana@usu.ac.id", "Xanana", "Xanana123" },
                    { new Guid("3e2d4b50-d4f6-acb7-8da4-0690416f030f"), "nurul@usu.ac.id", "Nurul", "Nurul123" },
                    { new Guid("40b14aec-a835-7143-9db1-69c954054357"), "candrakanta@usu.ac.id", "Candrakanta", "Candrakanta123" },
                    { new Guid("40f76385-ce54-2419-0dd6-e80c75b40255"), "langgeng@usu.ac.id", "Langgeng", "Langgeng123" },
                    { new Guid("4116a048-f490-6158-94b9-acf00286c815"), "garan@usu.ac.id", "Garan", "Garan123" },
                    { new Guid("42cd424d-983d-9cc2-d8cc-86474594ad68"), "patricia@usu.ac.id", "Patricia", "Patricia123" },
                    { new Guid("454abf84-f70e-78f0-77a1-f452012e7ad5"), "lutfan@usu.ac.id", "Lutfan", "Lutfan123" },
                    { new Guid("49e9317e-aa57-4ca9-fd3a-acc88eb84c0f"), "adiarja@usu.ac.id", "Adiarja", "Adiarja123" },
                    { new Guid("4fb224db-6c57-6f9e-83db-1ebf14ba09fd"), "adinata@usu.ac.id", "Adinata", "Adinata123" },
                    { new Guid("5472b5a1-2113-8164-a1e7-cfe22e0e5930"), "oni@usu.ac.id", "Oni", "Oni123" },
                    { new Guid("592b5b3c-c9af-9595-ebfc-31fc8e0997ee"), "amalia@usu.ac.id", "Amalia", "Amalia123" },
                    { new Guid("5b594793-6abc-f91a-8198-7a55700dea74"), "edi@usu.ac.id", "Edi", "Edi123" },
                    { new Guid("5dd6a668-5796-4ec7-e8dd-5e9c817abb61"), "ifa@usu.ac.id", "Ifa", "Ifa123" },
                    { new Guid("69fc612d-ad16-7d86-7b92-29915dc8ce22"), "eva@usu.ac.id", "Eva", "Eva123" },
                    { new Guid("6b7e3d78-68dc-0741-de7f-ac91f25ff9b5"), "caraka@usu.ac.id", "Caraka", "Caraka123" },
                    { new Guid("6c82e5e9-e137-3935-cfc3-7b5842307d5c"), "carla@usu.ac.id", "Carla", "Carla123" },
                    { new Guid("6db71b47-7d72-b4b7-de83-51d1fb38af48"), "lalita@usu.ac.id", "Lalita", "Lalita123" },
                    { new Guid("728014a7-9978-044d-d68c-a10a1be93e40"), "emil@usu.ac.id", "Emil", "Emil123" },
                    { new Guid("74650f07-e324-98e6-d845-4fb7ff88b492"), "kamidin@usu.ac.id", "Kamidin", "Kamidin123" },
                    { new Guid("7938f5a0-37d0-3e25-756f-cf4a36548740"), "galur@usu.ac.id", "Galur", "Galur123" },
                    { new Guid("79dec5a5-65a0-7220-ff08-6f9c17c55467"), "bahuwirya@usu.ac.id", "Bahuwirya", "Bahuwirya123" },
                    { new Guid("7c961a8f-0ce1-e2f6-43d6-f91668db9975"), "rafi@usu.ac.id", "Rafi", "Rafi123" },
                    { new Guid("7d052ae8-6ddf-c9b9-5cae-ee05d6244439"), "cinthia@usu.ac.id", "Cinthia", "Cinthia123" },
                    { new Guid("7fe68ec2-1a36-e6fa-a34a-8db8b0c01344"), "alambana@usu.ac.id", "Alambana", "Alambana123" },
                    { new Guid("7fea28c5-7116-26af-3fdf-5a2f2f5a9e5a"), "bella@usu.ac.id", "Bella", "Bella123" },
                    { new Guid("7ffe055a-cd5b-c51c-eb05-ecf633028248"), "puput@usu.ac.id", "Puput", "Puput123" },
                    { new Guid("803e1e6b-24ed-9380-d9ea-7ffa3747c54e"), "bala@usu.ac.id", "Bala", "Bala123" },
                    { new Guid("889d7d38-b143-8f35-124f-344b705bfb42"), "ciaobella@usu.ac.id", "Ciaobella", "Ciaobella123" },
                    { new Guid("8c3f8d6a-5105-4ce9-74b2-648ee8e8c390"), "asirwada@usu.ac.id", "Asirwada", "Asirwada123" },
                    { new Guid("908aa701-4f90-f5c6-4eb1-e2d06d6f3e25"), "olga@usu.ac.id", "Olga", "Olga123" },
                    { new Guid("92a0a7b3-a58a-5048-fd60-860d9f0df349"), "hartaka@usu.ac.id", "Hartaka", "Hartaka123" },
                    { new Guid("965d0089-94f0-39b5-243c-9fc74dcb8697"), "hasna@usu.ac.id", "Hasna", "Hasna123" },
                    { new Guid("965f6fa8-8e3f-adce-fa72-37a1ff8a6ddd"), "bala@usu.ac.id", "Bala", "Bala123" },
                    { new Guid("9694735a-f2c4-70a8-f1e1-d50aab2d3e9e"), "padma@usu.ac.id", "Padma", "Padma123" },
                    { new Guid("9936f8d0-7777-f233-ba9d-d15103408558"), "gilda@usu.ac.id", "Gilda", "Gilda123" },
                    { new Guid("99bdd58d-2d19-8843-324d-aa1016bdcb45"), "jono@usu.ac.id", "Jono", "Jono123" },
                    { new Guid("9b34714c-3056-70fb-da2d-a9bef3e63bde"), "jane@usu.ac.id", "Jane", "Jane123" },
                    { new Guid("9f6a1773-ea51-0396-421a-b14007ce52f4"), "natalia@usu.ac.id", "Natalia", "Natalia123" },
                    { new Guid("a089d177-8469-6c87-f5c4-93978ae11e52"), "kambali@usu.ac.id", "Kambali", "Kambali123" },
                    { new Guid("a2a88a81-a317-43ab-b0c6-d0ea0394a301"), "ismail@usu.ac.id", "Ismail", "Ismail123" },
                    { new Guid("a4ee2d9a-0862-bf55-29e3-57c873b1039d"), "kacung@usu.ac.id", "Kacung", "Kacung123" },
                    { new Guid("a7fe81cd-1351-bbf6-8788-4f2b6743c6f7"), "queen@usu.ac.id", "Queen", "Queen123" },
                    { new Guid("a95ee212-0137-fc15-8667-28778d6fd3a6"), "sabrina@usu.ac.id", "Sabrina", "Sabrina123" },
                    { new Guid("b0686d9e-2541-0793-cd06-7ee6187fbc47"), "saka@usu.ac.id", "Saka", "Saka123" },
                    { new Guid("b704417f-dd98-f4e5-9fc4-ef4accae5c72"), "jati@usu.ac.id", "Jati", "Jati123" },
                    { new Guid("b763165f-945d-8615-50c1-64e3d647f93f"), "rini@usu.ac.id", "Rini", "Rini123" },
                    { new Guid("b8e9f070-9e7c-cfa4-fc4b-0ceffe79a5e4"), "arsipatra@usu.ac.id", "Arsipatra", "Arsipatra123" },
                    { new Guid("bfb472c4-3b4f-7734-cd88-1ccc076311a4"), "karja@usu.ac.id", "Karja", "Karja123" },
                    { new Guid("c0749111-f02e-9b07-1de0-ebb66c962088"), "hilda@usu.ac.id", "Hilda", "Hilda123" },
                    { new Guid("c3249cce-6b50-a9ba-973e-5a2edd54c371"), "dartono@usu.ac.id", "Dartono", "Dartono123" },
                    { new Guid("c58ffb89-bbef-995f-c144-9f733458cf8f"), "tania@usu.ac.id", "Tania", "Tania123" },
                    { new Guid("c5966cf9-e974-8a95-4bbf-55c55e8a92e2"), "ozy@usu.ac.id", "Ozy", "Ozy123" },
                    { new Guid("c5d247a4-7c22-d264-1d83-f75c31dcfb54"), "kamaria@usu.ac.id", "Kamaria", "Kamaria123" },
                    { new Guid("cd196e5d-4ddf-0f42-de55-6aaca5e69d52"), "artawan@usu.ac.id", "Artawan", "Artawan123" },
                    { new Guid("cd4474c7-eb1a-d04a-7fe9-8cf5563521de"), "mitra@usu.ac.id", "Mitra", "Mitra123" },
                    { new Guid("cdd1c450-19d9-b9e5-e4f9-05fbfa3bc8ec"), "paulin@usu.ac.id", "Paulin", "Paulin123" },
                    { new Guid("dbd7e894-7bdc-9b88-eeb1-475944d6a10f"), "dimaz@usu.ac.id", "Dimaz", "Dimaz123" },
                    { new Guid("dbea875c-7dd7-64dc-2045-231b2c42ea83"), "cagak@usu.ac.id", "Cagak", "Cagak123" },
                    { new Guid("dc054298-0ccc-2bae-9089-ea910cb10f94"), "caraka@usu.ac.id", "Caraka", "Caraka123" },
                    { new Guid("dc9997bd-7b40-0be6-d4df-de69fcd006d9"), "radika@usu.ac.id", "Radika", "Radika123" },
                    { new Guid("dd83b458-b487-9311-23a9-4bd7e28c540e"), "satya@usu.ac.id", "Satya", "Satya123" },
                    { new Guid("e534f6d4-2be8-1a5c-18ed-754f43766a03"), "carla@usu.ac.id", "Carla", "Carla123" },
                    { new Guid("e59a1db9-be4b-010e-db2a-b6ba388af454"), "calista@usu.ac.id", "Calista", "Calista123" },
                    { new Guid("e8b1bc82-79ab-b83e-da25-3d287e2b6580"), "maria@usu.ac.id", "Maria", "Maria123" },
                    { new Guid("e98ce00a-1469-337b-45d7-7e97d33badfc"), "tina@usu.ac.id", "Tina", "Tina123" },
                    { new Guid("f15c59b5-358a-36a9-c029-35988f28c667"), "bagas@usu.ac.id", "Bagas", "Bagas123" },
                    { new Guid("f3e4594b-1813-112a-bc70-5f902fcb40a9"), "makuta@usu.ac.id", "Makuta", "Makuta123" },
                    { new Guid("f610ae12-7b56-1f91-0440-700986e77189"), "natalia@usu.ac.id", "Natalia", "Natalia123" },
                    { new Guid("fa1e3a71-9f8a-8536-0286-5f4e70e06d45"), "caraka@usu.ac.id", "Caraka", "Caraka123" },
                    { new Guid("fc38688c-64de-a99f-b877-58cbdd60390a"), "luthfi@usu.ac.id", "Luthfi", "Luthfi123" },
                    { new Guid("fcce2c0a-c0f4-f832-0dcd-33a91e8ca2ce"), "wirda@usu.ac.id", "Wirda", "Wirda123" },
                    { new Guid("fddd85a6-e6b1-0437-d35c-4975caf69093"), "endah@usu.ac.id", "Endah", "Endah123" },
                    { new Guid("febb6914-52d7-1ef6-f010-b07e8141b0d2"), "usyi@usu.ac.id", "Usyi", "Usyi123" }
                });
        }
    }
}
