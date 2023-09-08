using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomerAndCardAndHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("380c1add-b50e-459c-80b4-f176cacc7ac6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4032d32c-f008-4d63-bb3c-1524d2a12c6a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6023b604-6f25-4f16-953a-683270e6c235"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6317f7ed-ec94-4ba0-bd23-4de7856c280b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6fcb8921-fb46-4cd8-80d2-1acc8a521911"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("753e74c5-e720-4492-a6a8-2d725701d970"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("82d02ca5-6ee5-4065-ad13-3e6827a5e2ad"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bcb4e691-44b3-4580-b62f-6be043ca0991"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d17dcae0-36b3-48f9-8860-829b5d0a0aa2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("dd919828-f364-4ce6-88ed-912a77a486c5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f2552f83-e6bb-4996-8725-60d66ce89584"));

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OperationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_History_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CustomerId",
                table: "Cards",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_History_CardId",
                table: "History",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_History_CustomerId",
                table: "History",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Customers");

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("380c1add-b50e-459c-80b4-f176cacc7ac6"), "Nicholas_Treutel@yahoo.com", "Nicholas Treutel", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "597.314.1906 x1024", "developer", "Employee" },
                    { new Guid("4032d32c-f008-4d63-bb3c-1524d2a12c6a"), "Oliver_Dicki33@gmail.com", "Oliver Dicki", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "731-794-9558 x164", "hr", "Director" },
                    { new Guid("6023b604-6f25-4f16-953a-683270e6c235"), "Carolyn12@hotmail.com", "Carolyn Prohaska", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "(901) 488-1400 x67182", "developer", "Employee" },
                    { new Guid("6317f7ed-ec94-4ba0-bd23-4de7856c280b"), "Janie.Bruen@yahoo.com", "Janie Bruen", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "851.303.5920 x286", "hr", "Employee" },
                    { new Guid("6fcb8921-fb46-4cd8-80d2-1acc8a521911"), "Arnold_Flatley58@yahoo.com", "Arnold Flatley", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "987-516-5206 x20109", "Developer", "Admin" },
                    { new Guid("753e74c5-e720-4492-a6a8-2d725701d970"), "Clara_Bashirian@yahoo.com", "Clara Bashirian", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "1-932-758-9767", "developer", "Admin" },
                    { new Guid("82d02ca5-6ee5-4065-ad13-3e6827a5e2ad"), "Florence_Renner@gmail.com", "Florence Renner", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "526-617-1119", "security", "Director" },
                    { new Guid("bcb4e691-44b3-4580-b62f-6be043ca0991"), "Naomi_Daugherty@yahoo.com", "Naomi Daugherty", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "(498) 276-4247", "hr", "Admin" },
                    { new Guid("d17dcae0-36b3-48f9-8860-829b5d0a0aa2"), "Eloise_Williamson20@gmail.com", "Eloise Williamson", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "223.410.2681", "security", "Director" },
                    { new Guid("dd919828-f364-4ce6-88ed-912a77a486c5"), "Ida.Turner44@hotmail.com", "Ida Turner", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "630.456.2494 x292", "developer", "Admin" },
                    { new Guid("f2552f83-e6bb-4996-8725-60d66ce89584"), "Jaime_Jacobs@gmail.com", "Jaime Jacobs", "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw==", "1-756-926-3869 x81118", "cook", "Director" }
                });
        }
    }
}
