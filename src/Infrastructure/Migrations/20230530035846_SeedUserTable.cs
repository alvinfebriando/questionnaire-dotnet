using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Questionnaire.Infrastructure.Migrations
{
    public partial class SeedUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0233d0cb-e6c1-40f8-fbbe-24a0e751be30"), "nadine@usu.ac.id", "Nadine", "Nadine123" },
                    { new Guid("04e8a387-05b1-d2f0-a193-55c5a62ebbeb"), "kunthara@usu.ac.id", "Kunthara", "Kunthara123" },
                    { new Guid("0b729f48-b326-1a3c-7ea1-af1aa699e089"), "lamar@usu.ac.id", "Lamar", "Lamar123" },
                    { new Guid("0e771438-2c5a-fcfa-a7b5-b484c8b27a14"), "sakura@usu.ac.id", "Sakura", "Sakura123" },
                    { new Guid("107e9536-5fd4-4b44-891e-9e77eb5ca9ab"), "alvin@usu.ac.id", "Alvin", "alvin123" },
                    { new Guid("14274cc5-1c33-7d91-d7af-064f93d90b16"), "calista@usu.ac.id", "Calista", "Calista123" },
                    { new Guid("18492ab7-fe7d-0520-8354-943bcd98b839"), "hamzah@usu.ac.id", "Hamzah", "Hamzah123" },
                    { new Guid("185ecf52-22af-a044-9499-c5904344d102"), "chelsea@usu.ac.id", "Chelsea", "Chelsea123" },
                    { new Guid("1f494856-7f67-ea33-a127-dd8b0d3fe278"), "putri@usu.ac.id", "Putri", "Putri123" },
                    { new Guid("2710c8ad-df53-1c85-4c82-3ab18780f909"), "mursinin@usu.ac.id", "Mursinin", "Mursinin123" },
                    { new Guid("28fe19b3-31bf-7e19-e7b8-83c80c447106"), "gatra@usu.ac.id", "Gatra", "Gatra123" },
                    { new Guid("2ccf4bae-bf21-e005-26f2-a6d43d8d1d18"), "karen@usu.ac.id", "Karen", "Karen123" },
                    { new Guid("2d9b05e8-ae1d-953a-be29-0ababff63e79"), "lasmono@usu.ac.id", "Lasmono", "Lasmono123" },
                    { new Guid("2dc1d6f4-2b40-0ceb-671c-424268254502"), "yuliana@usu.ac.id", "Yuliana", "Yuliana123" },
                    { new Guid("318eb719-2d8c-2d06-481d-43e271aaa733"), "danu@usu.ac.id", "Danu", "Danu123" },
                    { new Guid("3277c706-e634-06b7-a46f-7a6a636800c9"), "salsabila@usu.ac.id", "Salsabila", "Salsabila123" },
                    { new Guid("3b876965-1bb0-b077-edf3-02f91775b6c2"), "vega@usu.ac.id", "Vega", "Vega123" },
                    { new Guid("3df9e2a4-18a3-2db4-0f27-ed75d1d61a46"), "ilsa@usu.ac.id", "Ilsa", "Ilsa123" },
                    { new Guid("41cdc211-9ad2-44df-9ad0-122014cd918b"), "admin@usu.ac.id", "Admin", "admin123" },
                    { new Guid("42107ffc-4a6f-aab5-f0d7-7f9ccd956ea1"), "umaya@usu.ac.id", "Umaya", "Umaya123" },
                    { new Guid("43cf7007-09ea-66a5-9db6-4675378b0043"), "kania@usu.ac.id", "Kania", "Kania123" },
                    { new Guid("4479079d-a2fe-ebaf-d013-6a77dc16b6fb"), "gaiman@usu.ac.id", "Gaiman", "Gaiman123" },
                    { new Guid("451f43fc-e9c0-df41-5f85-c64ada710867"), "kartika@usu.ac.id", "Kartika", "Kartika123" },
                    { new Guid("4783528f-bf73-6d7f-a09a-70a7eee65f02"), "rusman@usu.ac.id", "Rusman", "Rusman123" },
                    { new Guid("48f5df0c-1a73-3238-29ca-e05b76b98aa4"), "rika@usu.ac.id", "Rika", "Rika123" },
                    { new Guid("48fdfa65-b864-42f0-6fbb-3daf5fc70f75"), "kania@usu.ac.id", "Kania", "Kania123" },
                    { new Guid("4a07686b-a855-d006-51f1-50fca0ca3676"), "luwar@usu.ac.id", "Luwar", "Luwar123" },
                    { new Guid("4dc33bd7-0e6b-55b3-72bf-880674f8cd68"), "silvia@usu.ac.id", "Silvia", "Silvia123" },
                    { new Guid("4f63d9cb-153e-0e59-51fa-f9ade81a75ae"), "zamira@usu.ac.id", "Zamira", "Zamira123" },
                    { new Guid("5004b5f7-cd5c-d6c2-6861-78991759ff7e"), "jarwi@usu.ac.id", "Jarwi", "Jarwi123" },
                    { new Guid("529482dc-72e6-89ca-06e9-74cf8a913fea"), "dono@usu.ac.id", "Dono", "Dono123" },
                    { new Guid("5541c04b-1523-375f-bc1a-976fff90a341"), "zulaikha@usu.ac.id", "Zulaikha", "Zulaikha123" },
                    { new Guid("5559eac3-9934-daab-e948-ae62a57e72a4"), "ade@usu.ac.id", "Ade", "Ade123" },
                    { new Guid("575f5d61-4a1d-6ea9-6ea1-c1113aa9aeab"), "samiah@usu.ac.id", "Samiah", "Samiah123" },
                    { new Guid("59f8734d-5a44-9ded-0514-20b8d6a3e5bc"), "harimurti@usu.ac.id", "Harimurti", "Harimurti123" },
                    { new Guid("5bcc6a0c-7e62-5269-e865-200234d92f9d"), "gandewa@usu.ac.id", "Gandewa", "Gandewa123" },
                    { new Guid("5c5c531e-a5c2-dde7-583e-bfca65b59879"), "galak@usu.ac.id", "Galak", "Galak123" },
                    { new Guid("5ca56578-2ffe-229a-4d24-4538ed5f0f02"), "melinda@usu.ac.id", "Melinda", "Melinda123" },
                    { new Guid("5cd39ed8-59cf-fa2f-1bb2-e83efc0e0fd9"), "intan@usu.ac.id", "Intan", "Intan123" },
                    { new Guid("5ee9e1c6-d05f-0674-f99d-01d2763221bc"), "taswir@usu.ac.id", "Taswir", "Taswir123" },
                    { new Guid("61bf8128-5330-4fcf-6c06-83e67bc27f07"), "lukita@usu.ac.id", "Lukita", "Lukita123" },
                    { new Guid("662bdaad-44e8-06d7-9136-ba5c54aa85bb"), "icha@usu.ac.id", "Icha", "Icha123" },
                    { new Guid("68d5a9a6-3a04-3944-5c03-8716164767d1"), "jayeng@usu.ac.id", "Jayeng", "Jayeng123" },
                    { new Guid("6bf81299-b2f9-eba0-74cc-57c89ba25274"), "pangestu@usu.ac.id", "Pangestu", "Pangestu123" },
                    { new Guid("6dc9a8ae-72af-ad97-1a19-d5b7ea7bad34"), "keisha@usu.ac.id", "Keisha", "Keisha123" },
                    { new Guid("6e8173db-65aa-4b55-b030-eee00927cd39"), "febriando@usu.ac.id", "Febriando", "febriando123" },
                    { new Guid("750b55e4-7bd5-41dc-feef-f9aa3fdc5ae6"), "harto@usu.ac.id", "Harto", "Harto123" },
                    { new Guid("7a9de7a1-fac1-9b14-308b-d6342f5a5066"), "amalia@usu.ac.id", "Amalia", "Amalia123" },
                    { new Guid("7d43c2e3-38ec-7ab1-489d-dff20a53a47c"), "surya@usu.ac.id", "Surya", "Surya123" },
                    { new Guid("7da018cc-defa-11a9-b8d1-521f3f0805e0"), "virman@usu.ac.id", "Virman", "Virman123" },
                    { new Guid("82f203ef-66d1-f503-207d-d922efddcfc2"), "lanang@usu.ac.id", "Lanang", "Lanang123" },
                    { new Guid("83c747ea-9fb9-bcc5-115b-565ae0b32ba6"), "oman@usu.ac.id", "Oman", "Oman123" },
                    { new Guid("924f8a26-c8b7-d26a-68a6-4eba354ce82d"), "lega@usu.ac.id", "Lega", "Lega123" },
                    { new Guid("9330956d-b3f4-0c52-dc4a-ba01e3abf371"), "mumpuni@usu.ac.id", "Mumpuni", "Mumpuni123" },
                    { new Guid("9624ac54-ca9b-48ce-6279-2f2c49377293"), "karman@usu.ac.id", "Karman", "Karman123" },
                    { new Guid("97eda8b9-4856-2562-a1eb-f5e71629ccdf"), "ismail@usu.ac.id", "Ismail", "Ismail123" },
                    { new Guid("9f3e9bf6-c2b4-8181-f324-a156cee909e9"), "kani@usu.ac.id", "Kani", "Kani123" },
                    { new Guid("a02f155c-28aa-1238-8e4c-dbb29e04500e"), "cawisono@usu.ac.id", "Cawisono", "Cawisono123" },
                    { new Guid("a223cc2f-af4e-ba35-5749-f798764d8301"), "wardaya@usu.ac.id", "Wardaya", "Wardaya123" },
                    { new Guid("a2fc7cf0-0479-6ae8-409d-fef884e2e454"), "galur@usu.ac.id", "Galur", "Galur123" },
                    { new Guid("a6107d2e-e5e3-66ba-39af-55fb4fcd4089"), "cengkal@usu.ac.id", "Cengkal", "Cengkal123" },
                    { new Guid("a610fd3f-f6aa-0b95-eb8f-a46a55f16da7"), "kemal@usu.ac.id", "Kemal", "Kemal123" },
                    { new Guid("a6607bbc-49cd-8c4e-177a-c5598e35d868"), "yessi@usu.ac.id", "Yessi", "Yessi123" },
                    { new Guid("a9b04f09-4487-1fd7-d7c2-8efde3db1f0a"), "nyoman@usu.ac.id", "Nyoman", "Nyoman123" },
                    { new Guid("ab20c6a0-a67c-a441-9ad9-fd63f939e9dc"), "cahyo@usu.ac.id", "Cahyo", "Cahyo123" },
                    { new Guid("abd49037-0e54-78d1-53b9-136c133cc845"), "devi@usu.ac.id", "Devi", "Devi123" },
                    { new Guid("ac8297e6-050e-88ee-904b-ab82ea56c22e"), "kambali@usu.ac.id", "Kambali", "Kambali123" },
                    { new Guid("aee8ec9c-a61b-7dec-f0b6-e365097066db"), "endah@usu.ac.id", "Endah", "Endah123" },
                    { new Guid("b0851aa5-8d9d-4288-60d0-8f3c86d768e9"), "heryanto@usu.ac.id", "Heryanto", "Heryanto123" },
                    { new Guid("b2ef4200-e9ab-d74d-ab78-6ce8ef9164a8"), "safina@usu.ac.id", "Safina", "Safina123" },
                    { new Guid("b57353d8-73b3-4824-2e90-3dcc5d2fd777"), "ifa@usu.ac.id", "Ifa", "Ifa123" },
                    { new Guid("b5b28ba3-f0f0-4047-9991-fdfc10dfd1c5"), "dariati@usu.ac.id", "Dariati", "Dariati123" },
                    { new Guid("b71709aa-ef4a-02de-81a9-47d806005178"), "karsa@usu.ac.id", "Karsa", "Karsa123" },
                    { new Guid("b76cfa8c-a998-5af5-ffea-28704f03d11d"), "puji@usu.ac.id", "Puji", "Puji123" },
                    { new Guid("b914cb35-f88b-f124-0db4-c4f8c02b5767"), "vero@usu.ac.id", "Vero", "Vero123" },
                    { new Guid("ba78cc46-89b3-a099-928e-eb54747f435d"), "unjani@usu.ac.id", "Unjani", "Unjani123" },
                    { new Guid("bc5f5228-51d9-8344-3efe-13335560a61d"), "oliva@usu.ac.id", "Oliva", "Oliva123" },
                    { new Guid("bd0d688b-5818-98d7-5e15-5cedd25afb89"), "martani@usu.ac.id", "Martani", "Martani123" },
                    { new Guid("c37cbe52-17da-479f-767c-0c6afee7d8c5"), "danu@usu.ac.id", "Danu", "Danu123" },
                    { new Guid("c66b72da-0e4e-e67e-f328-1c4cb62b9c90"), "dian@usu.ac.id", "Dian", "Dian123" },
                    { new Guid("d79cd39a-85d1-9fa4-b50a-02a09c40c820"), "rachel@usu.ac.id", "Rachel", "Rachel123" },
                    { new Guid("dc1d9c67-0c04-b9b6-8320-218c202f4e49"), "kacung@usu.ac.id", "Kacung", "Kacung123" },
                    { new Guid("e0c02164-779b-a32e-08ea-02e26ae64b4d"), "dimaz@usu.ac.id", "Dimaz", "Dimaz123" },
                    { new Guid("e6ad19b9-448a-5f42-ec01-b0f5fd3af852"), "zelda@usu.ac.id", "Zelda", "Zelda123" },
                    { new Guid("e78a1fd9-dab0-1d95-8597-8e8f762067d7"), "lala@usu.ac.id", "Lala", "Lala123" },
                    { new Guid("eb216f36-1149-a75d-ee07-6e44abc25e49"), "hilda@usu.ac.id", "Hilda", "Hilda123" },
                    { new Guid("edb958df-76f7-5bca-04bd-121718287273"), "winda@usu.ac.id", "Winda", "Winda123" },
                    { new Guid("ef3f89b1-8047-c57e-3052-a19bf8080117"), "luwes@usu.ac.id", "Luwes", "Luwes123" },
                    { new Guid("ef7652f7-d719-c8fe-a4fb-ad162c52911d"), "arsipatra@usu.ac.id", "Arsipatra", "Arsipatra123" },
                    { new Guid("f08966a8-18fb-215a-1d54-97abfd060db5"), "kusuma@usu.ac.id", "Kusuma", "Kusuma123" },
                    { new Guid("f245b8a8-3380-504d-86ff-ad9d12df2636"), "luwes@usu.ac.id", "Luwes", "Luwes123" },
                    { new Guid("f27754ca-0285-058e-9869-c4a2e2ca90a5"), "kariman@usu.ac.id", "Kariman", "Kariman123" },
                    { new Guid("f2898a40-0a3f-4bdf-ce3f-1893cf9f27d6"), "cakrajiya@usu.ac.id", "Cakrajiya", "Cakrajiya123" },
                    { new Guid("f2ca4148-ec41-20f7-8a02-9d6b0af3dd5d"), "aurora@usu.ac.id", "Aurora", "Aurora123" },
                    { new Guid("f2d09c3b-192b-01dc-1cb4-561eca6f38c5"), "kartika@usu.ac.id", "Kartika", "Kartika123" },
                    { new Guid("f3cce24f-09b2-d5d6-1ff9-c6f36c80e20f"), "mariadi@usu.ac.id", "Mariadi", "Mariadi123" },
                    { new Guid("f49a3428-ebbc-835a-60cd-6f20304b706a"), "garda@usu.ac.id", "Garda", "Garda123" },
                    { new Guid("f56cbb1f-ae0a-afff-a390-d79bc421127b"), "iriana@usu.ac.id", "Iriana", "Iriana123" },
                    { new Guid("f655cf17-07b8-7cad-cf67-07fd89ef3572"), "harjasa@usu.ac.id", "Harjasa", "Harjasa123" },
                    { new Guid("f937fb1d-3bb1-b614-2230-769861f00dd3"), "cahyanto@usu.ac.id", "Cahyanto", "Cahyanto123" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0233d0cb-e6c1-40f8-fbbe-24a0e751be30"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("04e8a387-05b1-d2f0-a193-55c5a62ebbeb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b729f48-b326-1a3c-7ea1-af1aa699e089"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0e771438-2c5a-fcfa-a7b5-b484c8b27a14"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("107e9536-5fd4-4b44-891e-9e77eb5ca9ab"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("14274cc5-1c33-7d91-d7af-064f93d90b16"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("18492ab7-fe7d-0520-8354-943bcd98b839"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("185ecf52-22af-a044-9499-c5904344d102"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1f494856-7f67-ea33-a127-dd8b0d3fe278"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2710c8ad-df53-1c85-4c82-3ab18780f909"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("28fe19b3-31bf-7e19-e7b8-83c80c447106"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2ccf4bae-bf21-e005-26f2-a6d43d8d1d18"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2d9b05e8-ae1d-953a-be29-0ababff63e79"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2dc1d6f4-2b40-0ceb-671c-424268254502"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("318eb719-2d8c-2d06-481d-43e271aaa733"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3277c706-e634-06b7-a46f-7a6a636800c9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3b876965-1bb0-b077-edf3-02f91775b6c2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3df9e2a4-18a3-2db4-0f27-ed75d1d61a46"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("41cdc211-9ad2-44df-9ad0-122014cd918b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("42107ffc-4a6f-aab5-f0d7-7f9ccd956ea1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("43cf7007-09ea-66a5-9db6-4675378b0043"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4479079d-a2fe-ebaf-d013-6a77dc16b6fb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("451f43fc-e9c0-df41-5f85-c64ada710867"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4783528f-bf73-6d7f-a09a-70a7eee65f02"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("48f5df0c-1a73-3238-29ca-e05b76b98aa4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("48fdfa65-b864-42f0-6fbb-3daf5fc70f75"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4a07686b-a855-d006-51f1-50fca0ca3676"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4dc33bd7-0e6b-55b3-72bf-880674f8cd68"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4f63d9cb-153e-0e59-51fa-f9ade81a75ae"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5004b5f7-cd5c-d6c2-6861-78991759ff7e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("529482dc-72e6-89ca-06e9-74cf8a913fea"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5541c04b-1523-375f-bc1a-976fff90a341"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5559eac3-9934-daab-e948-ae62a57e72a4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("575f5d61-4a1d-6ea9-6ea1-c1113aa9aeab"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59f8734d-5a44-9ded-0514-20b8d6a3e5bc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5bcc6a0c-7e62-5269-e865-200234d92f9d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5c5c531e-a5c2-dde7-583e-bfca65b59879"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5ca56578-2ffe-229a-4d24-4538ed5f0f02"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5cd39ed8-59cf-fa2f-1bb2-e83efc0e0fd9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("5ee9e1c6-d05f-0674-f99d-01d2763221bc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("61bf8128-5330-4fcf-6c06-83e67bc27f07"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("662bdaad-44e8-06d7-9136-ba5c54aa85bb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("68d5a9a6-3a04-3944-5c03-8716164767d1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6bf81299-b2f9-eba0-74cc-57c89ba25274"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6dc9a8ae-72af-ad97-1a19-d5b7ea7bad34"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6e8173db-65aa-4b55-b030-eee00927cd39"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("750b55e4-7bd5-41dc-feef-f9aa3fdc5ae6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7a9de7a1-fac1-9b14-308b-d6342f5a5066"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7d43c2e3-38ec-7ab1-489d-dff20a53a47c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7da018cc-defa-11a9-b8d1-521f3f0805e0"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("82f203ef-66d1-f503-207d-d922efddcfc2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("83c747ea-9fb9-bcc5-115b-565ae0b32ba6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("924f8a26-c8b7-d26a-68a6-4eba354ce82d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9330956d-b3f4-0c52-dc4a-ba01e3abf371"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9624ac54-ca9b-48ce-6279-2f2c49377293"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("97eda8b9-4856-2562-a1eb-f5e71629ccdf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9f3e9bf6-c2b4-8181-f324-a156cee909e9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a02f155c-28aa-1238-8e4c-dbb29e04500e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a223cc2f-af4e-ba35-5749-f798764d8301"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a2fc7cf0-0479-6ae8-409d-fef884e2e454"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a6107d2e-e5e3-66ba-39af-55fb4fcd4089"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a610fd3f-f6aa-0b95-eb8f-a46a55f16da7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a6607bbc-49cd-8c4e-177a-c5598e35d868"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a9b04f09-4487-1fd7-d7c2-8efde3db1f0a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ab20c6a0-a67c-a441-9ad9-fd63f939e9dc"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("abd49037-0e54-78d1-53b9-136c133cc845"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ac8297e6-050e-88ee-904b-ab82ea56c22e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("aee8ec9c-a61b-7dec-f0b6-e365097066db"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b0851aa5-8d9d-4288-60d0-8f3c86d768e9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b2ef4200-e9ab-d74d-ab78-6ce8ef9164a8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b57353d8-73b3-4824-2e90-3dcc5d2fd777"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b5b28ba3-f0f0-4047-9991-fdfc10dfd1c5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b71709aa-ef4a-02de-81a9-47d806005178"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b76cfa8c-a998-5af5-ffea-28704f03d11d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b914cb35-f88b-f124-0db4-c4f8c02b5767"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ba78cc46-89b3-a099-928e-eb54747f435d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bc5f5228-51d9-8344-3efe-13335560a61d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bd0d688b-5818-98d7-5e15-5cedd25afb89"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c37cbe52-17da-479f-767c-0c6afee7d8c5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c66b72da-0e4e-e67e-f328-1c4cb62b9c90"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d79cd39a-85d1-9fa4-b50a-02a09c40c820"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dc1d9c67-0c04-b9b6-8320-218c202f4e49"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e0c02164-779b-a32e-08ea-02e26ae64b4d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e6ad19b9-448a-5f42-ec01-b0f5fd3af852"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e78a1fd9-dab0-1d95-8597-8e8f762067d7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eb216f36-1149-a75d-ee07-6e44abc25e49"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("edb958df-76f7-5bca-04bd-121718287273"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ef3f89b1-8047-c57e-3052-a19bf8080117"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ef7652f7-d719-c8fe-a4fb-ad162c52911d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f08966a8-18fb-215a-1d54-97abfd060db5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f245b8a8-3380-504d-86ff-ad9d12df2636"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f27754ca-0285-058e-9869-c4a2e2ca90a5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f2898a40-0a3f-4bdf-ce3f-1893cf9f27d6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f2ca4148-ec41-20f7-8a02-9d6b0af3dd5d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f2d09c3b-192b-01dc-1cb4-561eca6f38c5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f3cce24f-09b2-d5d6-1ff9-c6f36c80e20f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f49a3428-ebbc-835a-60cd-6f20304b706a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f56cbb1f-ae0a-afff-a390-d79bc421127b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f655cf17-07b8-7cad-cf67-07fd89ef3572"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f937fb1d-3bb1-b614-2230-769861f00dd3"));
        }
    }
}
