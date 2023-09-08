using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomerAndCardAndHistory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("20ee6c3b-9dca-48ec-a21f-797ddcd25bcf"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2c729442-8ca9-4fa8-b4ff-bdb5ac8807b2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("8a4a78f5-09b7-47c9-8a8f-066322131e57"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("8bacc402-c4cc-4415-b4ab-100b4e0b33db"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("96669f09-ae96-4704-b437-95668c6e5287"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a0249b8a-e523-4c54-816b-ea62c9178ed4"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a3c809b4-80b7-4040-8acd-c1819a7893f5"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("bae60921-c35a-4731-83ba-75687ff80155"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f3afa419-bd14-4f71-bef2-3e2a9e5eeb2c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f821b06e-53c8-4d61-a282-7c0dea1a106f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4ee170b5-3f25-4319-9a13-78d1b4c5b6b9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("535ac877-0565-4a9c-b130-946f04d2ac69"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9a06a0d1-806b-424c-8501-512836409990"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a89581ac-174c-4363-9e80-6685ec2f9ca7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d85fa081-d9fb-4260-87d2-f23231d75336"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f2bfa10a-7947-47c7-afbb-7e03db9a05aa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1bd44c6f-52c9-4de6-83e5-b612f5f25509"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("35dedcf4-2f4e-44a1-8848-5530e8c9da79"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("454101b6-c56a-440a-8e49-eeb3b8fdd3fc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("615367fd-5ac9-4c78-91ff-fe0e8596f6da"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6513f33e-a2a5-4ae1-992d-d7916523ae06"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("970cfb8a-e08f-4fd8-be3e-37b0f322cdd1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a9033a24-54c2-4520-b3b1-f35ac0470d0e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d13a851a-e094-4b76-a494-e7795e6b0cec"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f09b93c9-b778-42e5-9d51-e787489dbb59"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f55e69b1-2d88-4214-a4a5-edad6f9c1540"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("1bd44c6f-52c9-4de6-83e5-b612f5f25509"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("35dedcf4-2f4e-44a1-8848-5530e8c9da79"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("454101b6-c56a-440a-8e49-eeb3b8fdd3fc"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("615367fd-5ac9-4c78-91ff-fe0e8596f6da"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("6513f33e-a2a5-4ae1-992d-d7916523ae06"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("970cfb8a-e08f-4fd8-be3e-37b0f322cdd1"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("a9033a24-54c2-4520-b3b1-f35ac0470d0e"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("d13a851a-e094-4b76-a494-e7795e6b0cec"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("f09b93c9-b778-42e5-9d51-e787489dbb59"), "325-448-6608 x327", "Johnny Cole" },
                    { new Guid("f55e69b1-2d88-4214-a4a5-edad6f9c1540"), "325-448-6608 x327", "Johnny Cole" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("4ee170b5-3f25-4319-9a13-78d1b4c5b6b9"), "Johnny47@yahoo.com", "Johnny Cole", "123123123", "325-448-6608 x327", "cook", "Director" },
                    { new Guid("535ac877-0565-4a9c-b130-946f04d2ac69"), "Johnny47@yahoo.com", "Johnny Cole", "123123123", "325-448-6608 x327", "cook", "Director" },
                    { new Guid("9a06a0d1-806b-424c-8501-512836409990"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "325-448-6608 x327", "Developer", "Admin" },
                    { new Guid("a89581ac-174c-4363-9e80-6685ec2f9ca7"), "Johnny47@yahoo.com", "Johnny Cole", "123123123", "325-448-6608 x327", "hr", "Director" },
                    { new Guid("d85fa081-d9fb-4260-87d2-f23231d75336"), "Johnny47@yahoo.com", "Johnny Cole", "123123123", "325-448-6608 x327", "security", "Admin" },
                    { new Guid("f2bfa10a-7947-47c7-afbb-7e03db9a05aa"), "Johnny47@yahoo.com", "Johnny Cole", "123123123", "325-448-6608 x327", "hr", "Director" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("20ee6c3b-9dca-48ec-a21f-797ddcd25bcf"), "6371-8899-0118-1226", new Guid("35dedcf4-2f4e-44a1-8848-5530e8c9da79"), false, "109" },
                    { new Guid("2c729442-8ca9-4fa8-b4ff-bdb5ac8807b2"), "6521-6263-5238-5051-1202", new Guid("f09b93c9-b778-42e5-9d51-e787489dbb59"), false, "690" },
                    { new Guid("8a4a78f5-09b7-47c9-8a8f-066322131e57"), "5893-6364-8174-2146", new Guid("6513f33e-a2a5-4ae1-992d-d7916523ae06"), false, "846" },
                    { new Guid("8bacc402-c4cc-4415-b4ab-100b4e0b33db"), "6771-8915-4877-1803", new Guid("d13a851a-e094-4b76-a494-e7795e6b0cec"), false, "675" },
                    { new Guid("96669f09-ae96-4704-b437-95668c6e5287"), "3528-0943-4711-9042", new Guid("454101b6-c56a-440a-8e49-eeb3b8fdd3fc"), false, "224" },
                    { new Guid("a0249b8a-e523-4c54-816b-ea62c9178ed4"), "5407-2513-2231-6917", new Guid("f55e69b1-2d88-4214-a4a5-edad6f9c1540"), false, "994" },
                    { new Guid("a3c809b4-80b7-4040-8acd-c1819a7893f5"), "4612-2967-7275-7353", new Guid("a9033a24-54c2-4520-b3b1-f35ac0470d0e"), false, "592" },
                    { new Guid("bae60921-c35a-4731-83ba-75687ff80155"), "6578-6201-0025-3068-8356", new Guid("970cfb8a-e08f-4fd8-be3e-37b0f322cdd1"), false, "911" },
                    { new Guid("f3afa419-bd14-4f71-bef2-3e2a9e5eeb2c"), "589378351974133830", new Guid("1bd44c6f-52c9-4de6-83e5-b612f5f25509"), false, "029" },
                    { new Guid("f821b06e-53c8-4d61-a282-7c0dea1a106f"), "5143-9734-7718-2377", new Guid("615367fd-5ac9-4c78-91ff-fe0e8596f6da"), false, "757" }
                });
        }
    }
}
