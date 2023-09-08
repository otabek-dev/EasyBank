using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHistoryModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2526240e-db5f-4447-87b4-79c701ab40fd"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("41a6d02f-0cae-4815-b6db-8b269b5d6e70"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("45edb750-2524-416b-823d-b4ae7152a6bf"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5c19aa4f-4253-4735-83e5-a469a3f09a62"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a29be2bc-fb84-46ce-aed0-547b82bb882d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c5f7f118-4502-48f9-99d5-fc6f5758b0be"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c68cb9a0-e0c2-4d61-9cb1-56b32fb63eff"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("cb2afd88-3842-4388-9591-aebc9accb16a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("de70dd27-30b2-4abe-ae56-8ae76d1da0da"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e9ab7ccb-1678-43aa-ac7a-2833c19de3f8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1cfc9281-c63f-4901-890c-2ef1a0cd4316"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("91378948-4058-4d1c-9d11-016f23261fb5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b25b7481-536b-4934-bc84-86e3dc71a335"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b5b2c2c9-fa69-496d-b896-49a0c1ead991"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("da607a84-4cb1-4ec1-9897-75c5f16dfaa4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f460a4e3-527d-4d64-8164-c80556f16a1f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("290f4fc2-46ef-45c5-9872-5b3e7eebef36"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4012a619-b02d-476b-ab44-7f6558268a06"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("53258aa7-a780-4965-af01-ecb607115c55"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("53e7819d-dea0-4c6f-bdbd-a0d353bf183e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6590cc33-58b2-4a48-8f23-ed61ea2354c0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("70e3d08d-4fa8-471e-878a-61856a059745"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("941280e4-6df9-4eec-813b-17ba3be24f1c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f2321e0c-63a4-498a-ac16-1849d32bc30e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f67ca135-209e-47d5-9d83-9f4983be4b45"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fb9f4482-a04f-4b2d-aed0-24ef3c9a0023"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "History",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_History_EmployeeId",
                table: "History",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Employees_EmployeeId",
                table: "History",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Employees_EmployeeId",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_EmployeeId",
                table: "History");

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
                name: "EmployeeId",
                table: "History");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("290f4fc2-46ef-45c5-9872-5b3e7eebef36"), "(463) 875-0780", "Wilma Jerde" },
                    { new Guid("4012a619-b02d-476b-ab44-7f6558268a06"), "(720) 713-1574", "Rosemarie Mills" },
                    { new Guid("53258aa7-a780-4965-af01-ecb607115c55"), "(744) 485-1093", "James Wisoky" },
                    { new Guid("53e7819d-dea0-4c6f-bdbd-a0d353bf183e"), "(896) 738-0326 x2834", "Shelly Ullrich" },
                    { new Guid("6590cc33-58b2-4a48-8f23-ed61ea2354c0"), "549.886.8462", "Lola Buckridge" },
                    { new Guid("70e3d08d-4fa8-471e-878a-61856a059745"), "(972) 635-8421 x6829", "Victor Heidenreich" },
                    { new Guid("941280e4-6df9-4eec-813b-17ba3be24f1c"), "(658) 874-1180 x3992", "Flora O'Kon" },
                    { new Guid("f2321e0c-63a4-498a-ac16-1849d32bc30e"), "836.646.9283 x214", "Annie Beier" },
                    { new Guid("f67ca135-209e-47d5-9d83-9f4983be4b45"), "(912) 809-4063 x9668", "Cecil Conroy" },
                    { new Guid("fb9f4482-a04f-4b2d-aed0-24ef3c9a0023"), "834-988-5210", "Marcia Hartmann" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("1cfc9281-c63f-4901-890c-2ef1a0cd4316"), "Hugh35@gmail.com", "Hugh Bernier", "123123123", "759.500.0512", "cook", "Employee" },
                    { new Guid("91378948-4058-4d1c-9d11-016f23261fb5"), "Shelly.Wintheiser@hotmail.com", "Shelly Wintheiser", "123123123", "398-372-4933 x38264", "cook", "Employee" },
                    { new Guid("b25b7481-536b-4934-bc84-86e3dc71a335"), "Ramiro.Rolfson39@gmail.com", "Ramiro Rolfson", "123123123", "299.756.9869", "cook", "Admin" },
                    { new Guid("b5b2c2c9-fa69-496d-b896-49a0c1ead991"), "Ramon.Parisian@gmail.com", "Ramon Parisian", "123123123", "(273) 628-1907", "developer", "Employee" },
                    { new Guid("da607a84-4cb1-4ec1-9897-75c5f16dfaa4"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "1-394-290-2119 x9165", "Developer", "Admin" },
                    { new Guid("f460a4e3-527d-4d64-8164-c80556f16a1f"), "Lucia7@hotmail.com", "Lucia Mann", "123123123", "676-445-3765", "hr", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("2526240e-db5f-4447-87b4-79c701ab40fd"), "5018025875456406621", new Guid("290f4fc2-46ef-45c5-9872-5b3e7eebef36"), false, "078" },
                    { new Guid("41a6d02f-0cae-4815-b6db-8b269b5d6e70"), "3582-5504-7492-2196", new Guid("6590cc33-58b2-4a48-8f23-ed61ea2354c0"), false, "309" },
                    { new Guid("45edb750-2524-416b-823d-b4ae7152a6bf"), "6771334287919796", new Guid("53258aa7-a780-4965-af01-ecb607115c55"), false, "883" },
                    { new Guid("5c19aa4f-4253-4735-83e5-a469a3f09a62"), "6759-9068-5309-3480-83", new Guid("70e3d08d-4fa8-471e-878a-61856a059745"), false, "677" },
                    { new Guid("a29be2bc-fb84-46ce-aed0-547b82bb882d"), "5566-4237-4209-9251", new Guid("f67ca135-209e-47d5-9d83-9f4983be4b45"), false, "803" },
                    { new Guid("c5f7f118-4502-48f9-99d5-fc6f5758b0be"), "5487-1570-1238-3203", new Guid("941280e4-6df9-4eec-813b-17ba3be24f1c"), false, "911" },
                    { new Guid("c68cb9a0-e0c2-4d61-9cb1-56b32fb63eff"), "6767-2418-9751-2794", new Guid("4012a619-b02d-476b-ab44-7f6558268a06"), false, "568" },
                    { new Guid("cb2afd88-3842-4388-9591-aebc9accb16a"), "4482340272687", new Guid("53e7819d-dea0-4c6f-bdbd-a0d353bf183e"), false, "745" },
                    { new Guid("de70dd27-30b2-4abe-ae56-8ae76d1da0da"), "6759-8701-8313-6122", new Guid("f2321e0c-63a4-498a-ac16-1849d32bc30e"), false, "535" },
                    { new Guid("e9ab7ccb-1678-43aa-ac7a-2833c19de3f8"), "6443-6264-2114-6593-7756", new Guid("fb9f4482-a04f-4b2d-aed0-24ef3c9a0023"), false, "643" }
                });
        }
    }
}
