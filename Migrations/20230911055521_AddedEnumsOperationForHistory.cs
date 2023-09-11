using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class AddedEnumsOperationForHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("21a985f4-021b-4e9f-91f0-83651a27d442"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2654aefe-4fd1-48c1-a171-a6ca5eb16f54"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2f231e3b-e366-4ee0-a6d1-3d545aabcb59"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("483c85e7-bdf6-4bf3-8481-901a349dedf9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4cc78216-70d0-4ea6-9c60-49e2baa9f7ea"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("992c45b1-5b2d-4134-9586-6b6a6a80caf4"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a3b4b1a9-03b9-4259-bf69-8c3ea72b975c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c7549542-4afb-40e2-9304-35883955c2c9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d9f9cb11-3121-4c60-95c3-190028b81d2d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f32f632c-1128-41b0-b338-31338ba38fe1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("02ee667d-b2c1-484f-969d-7dcdc3220fc1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("28f8689d-f2db-4ad7-bf0d-a6b495e62a36"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("45c43049-e4ef-4455-904c-99f46fec4da4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("844a9041-0f22-466a-a355-0199463f8104"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ad1b5262-99f2-41fc-9918-3ca419b42aa0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("be6de4f0-1d4f-43c8-8dc2-3a17b9612665"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1a06f47d-a66a-4614-93d5-a1f15360e366"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2b01c0c7-b673-4bfb-9e01-f391fca96648"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("67ec6f99-2efe-4dfd-bc5c-ead352d1fada"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("748b2e6b-55dd-4ec7-9200-f113620bf300"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("86e1e7da-5b87-4191-9b1f-1b6c549dc913"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9ce0a659-6edf-4202-a752-e388927b19d6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9f31d285-1d74-44eb-b9a6-d145a14b2a03"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("acbe706c-c287-49ea-9f37-2c58c7d1b9d2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f34498d8-e3f6-479e-a16c-4e46ee26646e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f90a0da2-8aa6-4ef3-ab02-63e37b2b3337"));

            migrationBuilder.DropColumn(
                name: "OperatorId",
                table: "History");

            migrationBuilder.AlterColumn<int>(
                name: "OperationType",
                table: "History",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OperationDescription",
                table: "History",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OperationDescription",
                table: "History");

            migrationBuilder.AlterColumn<string>(
                name: "OperationType",
                table: "History",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "OperatorId",
                table: "History",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("1a06f47d-a66a-4614-93d5-a1f15360e366"), "1-571-758-8170 x9707", "Billie Windler" },
                    { new Guid("2b01c0c7-b673-4bfb-9e01-f391fca96648"), "826-820-9725 x7890", "Tony Larkin" },
                    { new Guid("67ec6f99-2efe-4dfd-bc5c-ead352d1fada"), "1-566-897-1962 x109", "Jan DuBuque" },
                    { new Guid("748b2e6b-55dd-4ec7-9200-f113620bf300"), "864-557-6290", "Eduardo Feeney" },
                    { new Guid("86e1e7da-5b87-4191-9b1f-1b6c549dc913"), "(221) 366-8280 x195", "Sheldon Barrows" },
                    { new Guid("9ce0a659-6edf-4202-a752-e388927b19d6"), "1-647-289-2494 x700", "Viola Schamberger" },
                    { new Guid("9f31d285-1d74-44eb-b9a6-d145a14b2a03"), "403.298.0806", "Alfonso Smitham" },
                    { new Guid("acbe706c-c287-49ea-9f37-2c58c7d1b9d2"), "1-549-359-8629 x702", "Rene Parisian" },
                    { new Guid("f34498d8-e3f6-479e-a16c-4e46ee26646e"), "1-787-587-8137", "Viola Greenfelder" },
                    { new Guid("f90a0da2-8aa6-4ef3-ab02-63e37b2b3337"), "1-674-299-1280", "Bobbie Hintz" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("02ee667d-b2c1-484f-969d-7dcdc3220fc1"), "Francis41@gmail.com", "Francis Cremin", "123123123", "1-719-370-1506 x487", "cook", "Admin" },
                    { new Guid("28f8689d-f2db-4ad7-bf0d-a6b495e62a36"), "Terry.Kutch90@yahoo.com", "Terry Kutch", "123123123", "(404) 795-0653", "developer", "Admin" },
                    { new Guid("45c43049-e4ef-4455-904c-99f46fec4da4"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "349-665-2458 x9800", "Developer", "Admin" },
                    { new Guid("844a9041-0f22-466a-a355-0199463f8104"), "Rudy20@hotmail.com", "Rudy Smitham", "123123123", "(816) 724-1699", "security", "Admin" },
                    { new Guid("ad1b5262-99f2-41fc-9918-3ca419b42aa0"), "Sara_Klocko@gmail.com", "Sara Klocko", "123123123", "(619) 704-7138 x02077", "cook", "Director" },
                    { new Guid("be6de4f0-1d4f-43c8-8dc2-3a17b9612665"), "Isaac.Schuppe33@gmail.com", "Isaac Schuppe", "123123123", "323-484-7583 x8995", "developer", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("21a985f4-021b-4e9f-91f0-83651a27d442"), "503866258335256731", new Guid("acbe706c-c287-49ea-9f37-2c58c7d1b9d2"), false, "671" },
                    { new Guid("2654aefe-4fd1-48c1-a171-a6ca5eb16f54"), "675997444034189054", new Guid("f90a0da2-8aa6-4ef3-ab02-63e37b2b3337"), false, "798" },
                    { new Guid("2f231e3b-e366-4ee0-a6d1-3d545aabcb59"), "6011-5504-4149-3192", new Guid("1a06f47d-a66a-4614-93d5-a1f15360e366"), false, "801" },
                    { new Guid("483c85e7-bdf6-4bf3-8481-901a349dedf9"), "5482-9497-8583-4130", new Guid("2b01c0c7-b673-4bfb-9e01-f391fca96648"), false, "520" },
                    { new Guid("4cc78216-70d0-4ea6-9c60-49e2baa9f7ea"), "5515-4139-8377-4946", new Guid("67ec6f99-2efe-4dfd-bc5c-ead352d1fada"), false, "754" },
                    { new Guid("992c45b1-5b2d-4134-9586-6b6a6a80caf4"), "3019-625126-2440", new Guid("9ce0a659-6edf-4202-a752-e388927b19d6"), false, "414" },
                    { new Guid("a3b4b1a9-03b9-4259-bf69-8c3ea72b975c"), "3765-416645-94883", new Guid("f34498d8-e3f6-479e-a16c-4e46ee26646e"), false, "881" },
                    { new Guid("c7549542-4afb-40e2-9304-35883955c2c9"), "6397-3974-1578-5391", new Guid("86e1e7da-5b87-4191-9b1f-1b6c549dc913"), false, "120" },
                    { new Guid("d9f9cb11-3121-4c60-95c3-190028b81d2d"), "3696-043122-5815", new Guid("748b2e6b-55dd-4ec7-9200-f113620bf300"), false, "851" },
                    { new Guid("f32f632c-1128-41b0-b338-31338ba38fe1"), "6759-8755-3163-7218", new Guid("9f31d285-1d74-44eb-b9a6-d145a14b2a03"), false, "965" }
                });
        }
    }
}
