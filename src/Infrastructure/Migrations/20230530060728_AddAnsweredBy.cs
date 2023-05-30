using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class AddAnsweredBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurveyUser",
                columns: table => new
                {
                    AnsweredById = table.Column<Guid>(type: "uuid", nullable: false),
                    SurveysId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyUser", x => new { x.AnsweredById, x.SurveysId });
                    table.ForeignKey(
                        name: "FK_SurveyUser_Surveys_SurveysId",
                        column: x => x.SurveysId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SurveyUser_Users_AnsweredById",
                        column: x => x.AnsweredById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { new Guid("107e9536-5fd4-4b44-891e-9e77eb5ca9ab"), "alvin@usu.ac.id", "Alvin", "alvin123" },
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
                    { new Guid("41cdc211-9ad2-44df-9ad0-122014cd918b"), "admin@usu.ac.id", "Admin", "admin123" },
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
                    { new Guid("6e8173db-65aa-4b55-b030-eee00927cd39"), "febriando@usu.ac.id", "Febriando", "febriando123" },
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

            migrationBuilder.CreateIndex(
                name: "IX_SurveyUser_SurveysId",
                table: "SurveyUser",
                column: "SurveysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyUser");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
