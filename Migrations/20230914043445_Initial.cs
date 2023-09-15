using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: false),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmployeeId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CardNumber = table.Column<string>(type: "text", nullable: false),
                    PinCode = table.Column<string>(type: "text", nullable: false),
                    IsBlocked = table.Column<bool>(type: "boolean", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OperationType = table.Column<int>(type: "integer", nullable: false),
                    OperationDescription = table.Column<int>(type: "integer", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: true),
                    CardId = table.Column<Guid>(type: "uuid", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_History_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("19afa6e8-5b3b-4457-b20e-59a9e34190cd"), "314-248-3458 x3514", "Carlton Anderson" },
                    { new Guid("1d060d87-1651-4019-8120-a9cdbcad4e50"), "795-859-7679", "Joey Connelly" },
                    { new Guid("2841872a-1f16-41b1-8c70-9ec728baf976"), "847-637-6551", "Fannie Legros" },
                    { new Guid("6a70dca6-4e81-4bfb-a763-7d088ca3f405"), "(632) 767-2020 x7497", "Leigh Dicki" },
                    { new Guid("6bcc84a8-c021-4f9f-b547-b68dd5656403"), "1-929-562-5347", "Sarah Daugherty" },
                    { new Guid("8d322838-0270-45c9-b40b-8c18424aa519"), "(832) 796-8968 x17447", "Benjamin Weber" },
                    { new Guid("dcc390fe-7233-4ba8-9aff-a2fa9f511b50"), "403.217.3445", "Dale Dare" },
                    { new Guid("eca0bc65-c40d-4e05-a744-c74fce8cb9a6"), "929-932-1755 x16257", "Shelly Kassulke" },
                    { new Guid("f17ec1e2-1759-48bd-9090-e6bca65c1883"), "796-757-1539 x27721", "Corey Flatley" },
                    { new Guid("fea4c48e-d307-4e88-8fcf-7f57c3600f9e"), "(439) 322-3085 x52714", "Vincent McDermott" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("1e42e661-1530-4326-bdf1-46b1b48fd2da"), "Francisco.Lynch50@hotmail.com", "Francisco Lynch", "123123123", "555-872-5080 x8993", "cook", "Director" },
                    { new Guid("1f6b0a86-084d-4d9f-8417-3dc506273fab"), "Theodore.Turcotte37@hotmail.com", "Theodore Turcotte", "123123123", "857-768-5449", "hr", "Employee" },
                    { new Guid("2763740f-ed19-432d-84c8-bd8caf6735d0"), "Jonathon.Durgan@gmail.com", "Jonathon Durgan", "123123123", "1-234-792-5593 x25195", "developer", "Employee" },
                    { new Guid("4f6787d8-0be7-4a23-9200-de90b2265cfc"), "Delbert_Schiller@hotmail.com", "Delbert Schiller", "123123123", "(429) 875-2648", "developer", "Director" },
                    { new Guid("7def9946-13a0-4a60-8fe2-164cf45a14ab"), "Melanie40@hotmail.com", "Melanie O'Reilly", "123123123", "(649) 773-2186 x0401", "security", "Director" },
                    { new Guid("adbf277a-3c40-47dc-9425-081e8cb2563a"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "1-364-246-6467", "Developer", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("2782eb2e-4744-49ff-8e17-9d707dfdfad8"), "5893124714867052821", new Guid("1d060d87-1651-4019-8120-a9cdbcad4e50"), false, "244" },
                    { new Guid("3ae0a6f0-c46e-463c-9f65-db64c24db4f0"), "6759-9019-1414-0636", new Guid("6a70dca6-4e81-4bfb-a763-7d088ca3f405"), false, "312" },
                    { new Guid("3bd039d9-f447-4a95-99f5-82fef8e4392e"), "5893-7297-5155-6500", new Guid("8d322838-0270-45c9-b40b-8c18424aa519"), false, "906" },
                    { new Guid("61cd3c7e-260d-40b2-96a1-6a5e649035ae"), "6370-1409-2745-9944", new Guid("eca0bc65-c40d-4e05-a744-c74fce8cb9a6"), false, "386" },
                    { new Guid("7463dd7d-3f76-4ffc-b6be-04ec339607c0"), "3486-709562-87461", new Guid("dcc390fe-7233-4ba8-9aff-a2fa9f511b50"), false, "438" },
                    { new Guid("a897bbf1-9907-4b30-a820-a856349b897d"), "6709794349045873164", new Guid("19afa6e8-5b3b-4457-b20e-59a9e34190cd"), false, "214" },
                    { new Guid("bac48d99-713b-4b95-baec-c12380733df2"), "6767-3351-7440-4774-512", new Guid("6bcc84a8-c021-4f9f-b547-b68dd5656403"), false, "141" },
                    { new Guid("bb629707-3bfe-4472-b149-3555656716d8"), "3491-713085-04280", new Guid("f17ec1e2-1759-48bd-9090-e6bca65c1883"), false, "529" },
                    { new Guid("cc0b6314-af99-4bba-bb3a-e53c034c7204"), "4701925153461", new Guid("2841872a-1f16-41b1-8c70-9ec728baf976"), false, "982" },
                    { new Guid("df673b2d-8ca1-4717-9380-070e10be37f3"), "6706601664241194382", new Guid("fea4c48e-d307-4e88-8fcf-7f57c3600f9e"), false, "180" }
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

            migrationBuilder.CreateIndex(
                name: "IX_History_EmployeeId",
                table: "History",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
