using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class AddedRefreshTokens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("06e389e9-7890-42d5-bb65-26aed1344a57"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2e161efb-9a8d-4b9a-b75a-2466ffe3211a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2fa9bbd6-47d1-440e-a316-2ea7d894545e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("3bb4ae49-3891-43c5-b3d2-e5d2b3388411"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("6a31d8df-9622-4df3-96dc-b19526e25996"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("81eeba88-591b-423a-9aca-658207313bd9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("92092a80-5af7-44ce-80dc-fdad92a4467d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ee2a08b3-139c-44a9-b274-b68b2f465342"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("eec43b6b-ed0f-41b4-85ad-d82d2fd4ffe0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f07d7e34-1f3f-45a5-b05f-8cc0f6246da4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6252093a-e4d0-4719-bdda-99585f4090f9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7cda62f9-c7f0-41a4-ac2f-378a0fc88cfa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9665e61f-c5b0-4eaf-b66f-3eaec571fbf6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a8aa50b3-0fdb-4831-bc09-3d853ff6615e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bca66b27-fdd9-4df1-8669-b7d50a0dbd6f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fe77afb2-1ba3-4d9b-bbc8-9b67f6960386"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0afe3a22-6d33-4d71-91c8-366af31ab4e9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("10b2cc5e-c079-439a-abe6-397e182248cd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2f99bd73-d693-4d9e-9052-6e36d974630e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4d277fc9-c446-4fd6-b5d8-8383a11bb19d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("53906d01-5a9a-4907-83e7-4a95a5115dbb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6dfe28f4-f4bf-48ad-a98e-19299dd89658"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("994f6da7-487c-4e57-9e13-f850b6f593a4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("db17d82f-ae8b-4baf-a7de-c96ddf223fb4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e86bb06e-27f6-4670-b194-77ba704f05cc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fac1f91b-22f5-428d-ac17-4bf73679bf19"));

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("0a4ff21e-ff7c-4eeb-ba53-dfede6387a75"), "1-851-647-0551 x3225", "Raquel Kemmer" },
                    { new Guid("40d2d041-10a1-42e1-aa81-6278272411f1"), "(801) 946-7295 x98272", "Melody Okuneva" },
                    { new Guid("51e4e254-5a26-47fe-95db-2fdb4905b952"), "1-323-582-1328 x1464", "Alan Wiegand" },
                    { new Guid("64a297a4-ca1b-4dd5-bf34-ed06822f0fda"), "758.786.0436 x3798", "Joseph Kiehn" },
                    { new Guid("6fd50aee-7bc2-41d8-91dc-0545951f8339"), "756.981.7431 x850", "Ralph Hintz" },
                    { new Guid("853cac5e-7d3a-4f35-8909-7a3ed5f87603"), "551-889-9225 x049", "Cora Keeling" },
                    { new Guid("9bc7b509-b7bf-456e-ae60-a6f1ed86901f"), "(448) 260-3708 x71042", "Sandy Lehner" },
                    { new Guid("a5fa41d1-58df-4523-a8a1-9d968f488428"), "(771) 344-2897", "Cedric O'Keefe" },
                    { new Guid("d56ee317-2c0b-467b-adca-430aead0230d"), "691-737-6611", "Christie Stokes" },
                    { new Guid("f85c9430-e027-4d7a-9978-1e9eedba21a8"), "(970) 926-8684 x67123", "Clifford Wehner" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("373df8ad-d11d-460f-9c96-6a0d8b73eec3"), "Sue_Rutherford9@gmail.com", "Sue Rutherford", "123123123", "1-695-867-8294 x33812", "cook", "Director" },
                    { new Guid("3d571baf-4203-43d7-95b3-ff5506f4f6b2"), "Roger23@gmail.com", "Roger Littel", "123123123", "1-428-454-2228", "security", "Admin" },
                    { new Guid("78549e86-3681-4c02-a29f-49d0c3f75d95"), "Erika_Kreiger@yahoo.com", "Erika Kreiger", "123123123", "1-593-487-4661", "developer", "Employee" },
                    { new Guid("93249b5e-679f-473a-85c6-e5f9b192003f"), "Jeremiah_Bradtke@gmail.com", "Jeremiah Bradtke", "123123123", "800-841-7700 x7157", "cook", "Employee" },
                    { new Guid("eaded916-695a-446e-ac88-edb770589bef"), "Sara_Kessler54@yahoo.com", "Sara Kessler", "123123123", "220-259-7151 x0874", "security", "Admin" },
                    { new Guid("f7210738-5773-4974-b10e-6b3015e07335"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "403.793.9706", "Developer", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("001a9e40-2e2b-43c0-875f-07f8f1e315dc"), "6379-4415-5537-5571", new Guid("a5fa41d1-58df-4523-a8a1-9d968f488428"), false, "860" },
                    { new Guid("0c1e7323-1c06-4580-933f-3f91f2bc2af1"), "5038-8226-9852-9031", new Guid("9bc7b509-b7bf-456e-ae60-a6f1ed86901f"), false, "874" },
                    { new Guid("365d3e7f-f509-49f1-92be-b270dade2943"), "4432-7195-9505-2478", new Guid("40d2d041-10a1-42e1-aa81-6278272411f1"), false, "991" },
                    { new Guid("5351d3de-0023-423f-aa61-ac9c3a5c3d37"), "3542-7538-9690-4037", new Guid("d56ee317-2c0b-467b-adca-430aead0230d"), false, "588" },
                    { new Guid("57195153-14eb-44b1-8dc3-43220a319808"), "6706196891326241", new Guid("0a4ff21e-ff7c-4eeb-ba53-dfede6387a75"), false, "296" },
                    { new Guid("66396780-1bd7-4ca9-8d64-15ce9084f70e"), "3054-947317-8887", new Guid("853cac5e-7d3a-4f35-8909-7a3ed5f87603"), false, "900" },
                    { new Guid("95239a29-80e9-4af5-90b2-f91a2f59d825"), "6387-7868-6679-1977", new Guid("64a297a4-ca1b-4dd5-bf34-ed06822f0fda"), false, "116" },
                    { new Guid("a5baad50-bf91-4174-91f6-7762c470996c"), "3702-966391-55528", new Guid("6fd50aee-7bc2-41d8-91dc-0545951f8339"), false, "340" },
                    { new Guid("b3cd6011-640a-4fa2-848b-0877c4671f10"), "3635-964551-9495", new Guid("f85c9430-e027-4d7a-9978-1e9eedba21a8"), false, "912" },
                    { new Guid("ee6bbf72-3fef-4958-94d9-279bf062614c"), "6759-6919-5946-7026-155", new Guid("51e4e254-5a26-47fe-95db-2fdb4905b952"), false, "690" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("001a9e40-2e2b-43c0-875f-07f8f1e315dc"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0c1e7323-1c06-4580-933f-3f91f2bc2af1"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("365d3e7f-f509-49f1-92be-b270dade2943"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5351d3de-0023-423f-aa61-ac9c3a5c3d37"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("57195153-14eb-44b1-8dc3-43220a319808"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("66396780-1bd7-4ca9-8d64-15ce9084f70e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("95239a29-80e9-4af5-90b2-f91a2f59d825"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a5baad50-bf91-4174-91f6-7762c470996c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b3cd6011-640a-4fa2-848b-0877c4671f10"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ee6bbf72-3fef-4958-94d9-279bf062614c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("373df8ad-d11d-460f-9c96-6a0d8b73eec3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3d571baf-4203-43d7-95b3-ff5506f4f6b2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("78549e86-3681-4c02-a29f-49d0c3f75d95"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("93249b5e-679f-473a-85c6-e5f9b192003f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eaded916-695a-446e-ac88-edb770589bef"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f7210738-5773-4974-b10e-6b3015e07335"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0a4ff21e-ff7c-4eeb-ba53-dfede6387a75"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("40d2d041-10a1-42e1-aa81-6278272411f1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("51e4e254-5a26-47fe-95db-2fdb4905b952"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("64a297a4-ca1b-4dd5-bf34-ed06822f0fda"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6fd50aee-7bc2-41d8-91dc-0545951f8339"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("853cac5e-7d3a-4f35-8909-7a3ed5f87603"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9bc7b509-b7bf-456e-ae60-a6f1ed86901f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a5fa41d1-58df-4523-a8a1-9d968f488428"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d56ee317-2c0b-467b-adca-430aead0230d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f85c9430-e027-4d7a-9978-1e9eedba21a8"));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("0afe3a22-6d33-4d71-91c8-366af31ab4e9"), "991-708-0343 x48933", "Essie Dare" },
                    { new Guid("10b2cc5e-c079-439a-abe6-397e182248cd"), "(463) 258-9623", "Juanita Denesik" },
                    { new Guid("2f99bd73-d693-4d9e-9052-6e36d974630e"), "(221) 724-4357", "Edmond Bernhard" },
                    { new Guid("4d277fc9-c446-4fd6-b5d8-8383a11bb19d"), "342-935-0550 x05062", "Omar Schaefer" },
                    { new Guid("53906d01-5a9a-4907-83e7-4a95a5115dbb"), "827-507-0953 x8772", "Cathy Lynch" },
                    { new Guid("6dfe28f4-f4bf-48ad-a98e-19299dd89658"), "(601) 423-4723 x350", "Joey Parker" },
                    { new Guid("994f6da7-487c-4e57-9e13-f850b6f593a4"), "785-591-3029 x28067", "Pearl Berge" },
                    { new Guid("db17d82f-ae8b-4baf-a7de-c96ddf223fb4"), "358-299-7851", "Elsa Williamson" },
                    { new Guid("e86bb06e-27f6-4670-b194-77ba704f05cc"), "387.659.4261 x3635", "Gayle Lueilwitz" },
                    { new Guid("fac1f91b-22f5-428d-ac17-4bf73679bf19"), "346.559.7907 x10457", "Nathan Bednar" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("6252093a-e4d0-4719-bdda-99585f4090f9"), "Christian32@gmail.com", "Christian Trantow", "123123123", "633.736.7691 x064", "hr", "Admin" },
                    { new Guid("7cda62f9-c7f0-41a4-ac2f-378a0fc88cfa"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "785.749.0471 x1237", "Developer", "Admin" },
                    { new Guid("9665e61f-c5b0-4eaf-b66f-3eaec571fbf6"), "Alexis.Ward52@hotmail.com", "Alexis Ward", "123123123", "967.422.9818 x51130", "cook", "Director" },
                    { new Guid("a8aa50b3-0fdb-4831-bc09-3d853ff6615e"), "Mona_Crooks47@yahoo.com", "Mona Crooks", "123123123", "598-463-4477", "security", "Director" },
                    { new Guid("bca66b27-fdd9-4df1-8669-b7d50a0dbd6f"), "Sam.Bergstrom65@yahoo.com", "Sam Bergstrom", "123123123", "(234) 936-5664", "cook", "Admin" },
                    { new Guid("fe77afb2-1ba3-4d9b-bbc8-9b67f6960386"), "Velma_Nader7@yahoo.com", "Velma Nader", "123123123", "1-917-602-9348", "security", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("06e389e9-7890-42d5-bb65-26aed1344a57"), "3529-2448-9732-9132", new Guid("2f99bd73-d693-4d9e-9052-6e36d974630e"), false, "652" },
                    { new Guid("2e161efb-9a8d-4b9a-b75a-2466ffe3211a"), "3528-8021-3983-5744", new Guid("53906d01-5a9a-4907-83e7-4a95a5115dbb"), false, "011" },
                    { new Guid("2fa9bbd6-47d1-440e-a316-2ea7d894545e"), "6767-1915-9102-0521", new Guid("6dfe28f4-f4bf-48ad-a98e-19299dd89658"), false, "604" },
                    { new Guid("3bb4ae49-3891-43c5-b3d2-e5d2b3388411"), "6706903614536273", new Guid("10b2cc5e-c079-439a-abe6-397e182248cd"), false, "211" },
                    { new Guid("6a31d8df-9622-4df3-96dc-b19526e25996"), "3420-130771-85551", new Guid("fac1f91b-22f5-428d-ac17-4bf73679bf19"), false, "349" },
                    { new Guid("81eeba88-591b-423a-9aca-658207313bd9"), "6759-6376-1600-0677-848", new Guid("994f6da7-487c-4e57-9e13-f850b6f593a4"), false, "307" },
                    { new Guid("92092a80-5af7-44ce-80dc-fdad92a4467d"), "6767-6520-2921-4091-868", new Guid("e86bb06e-27f6-4670-b194-77ba704f05cc"), false, "868" },
                    { new Guid("ee2a08b3-139c-44a9-b274-b68b2f465342"), "6771347039560981", new Guid("db17d82f-ae8b-4baf-a7de-c96ddf223fb4"), false, "349" },
                    { new Guid("eec43b6b-ed0f-41b4-85ad-d82d2fd4ffe0"), "6383-5225-2908-4854", new Guid("0afe3a22-6d33-4d71-91c8-366af31ab4e9"), false, "173" },
                    { new Guid("f07d7e34-1f3f-45a5-b05f-8cc0f6246da4"), "5893419175184309", new Guid("4d277fc9-c446-4fd6-b5d8-8383a11bb19d"), false, "072" }
                });
        }
    }
}
