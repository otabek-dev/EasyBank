using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
