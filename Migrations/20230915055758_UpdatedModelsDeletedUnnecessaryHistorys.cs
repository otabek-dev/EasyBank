using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedModelsDeletedUnnecessaryHistorys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Cards_CardId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Customers_CustomerId",
                table: "History");

            migrationBuilder.DropForeignKey(
                name: "FK_History_Employees_EmployeeId",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_CardId",
                table: "History");

            migrationBuilder.DropIndex(
                name: "IX_History_CustomerId",
                table: "History");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2782eb2e-4744-49ff-8e17-9d707dfdfad8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("3ae0a6f0-c46e-463c-9f65-db64c24db4f0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("3bd039d9-f447-4a95-99f5-82fef8e4392e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("61cd3c7e-260d-40b2-96a1-6a5e649035ae"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("7463dd7d-3f76-4ffc-b6be-04ec339607c0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a897bbf1-9907-4b30-a820-a856349b897d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("bac48d99-713b-4b95-baec-c12380733df2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("bb629707-3bfe-4472-b149-3555656716d8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("cc0b6314-af99-4bba-bb3a-e53c034c7204"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("df673b2d-8ca1-4717-9380-070e10be37f3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1e42e661-1530-4326-bdf1-46b1b48fd2da"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1f6b0a86-084d-4d9f-8417-3dc506273fab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2763740f-ed19-432d-84c8-bd8caf6735d0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4f6787d8-0be7-4a23-9200-de90b2265cfc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7def9946-13a0-4a60-8fe2-164cf45a14ab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("adbf277a-3c40-47dc-9425-081e8cb2563a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("19afa6e8-5b3b-4457-b20e-59a9e34190cd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1d060d87-1651-4019-8120-a9cdbcad4e50"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2841872a-1f16-41b1-8c70-9ec728baf976"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6a70dca6-4e81-4bfb-a763-7d088ca3f405"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6bcc84a8-c021-4f9f-b547-b68dd5656403"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8d322838-0270-45c9-b40b-8c18424aa519"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("dcc390fe-7233-4ba8-9aff-a2fa9f511b50"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("eca0bc65-c40d-4e05-a744-c74fce8cb9a6"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f17ec1e2-1759-48bd-9090-e6bca65c1883"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fea4c48e-d307-4e88-8fcf-7f57c3600f9e"));

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "History");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "History");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("0916b01d-8c68-444d-93f2-337903498924"), "1-350-509-4987 x52714", "Jake Padberg" },
                    { new Guid("13e4600b-f4da-4296-8dac-4cecadf92997"), "644.618.6464", "Toni Treutel" },
                    { new Guid("2716d91f-7a75-4898-921c-946780e3b87e"), "(517) 770-1369", "Jackie Russel" },
                    { new Guid("349b38e8-e849-45cb-a176-721782198e5e"), "1-464-375-8534", "Katrina Roob" },
                    { new Guid("3e774720-bbe2-48a2-bdd0-a90679f16dd0"), "260-871-2757 x4499", "Hannah McDermott" },
                    { new Guid("40398b13-8282-4e8c-9e43-69b823cfbacd"), "1-477-312-0879 x639", "Erick Kling" },
                    { new Guid("4a5f5d2d-7da3-4af8-bae3-b2d8b590a1e4"), "1-260-740-0442 x43346", "Gabriel Abbott" },
                    { new Guid("4c78d4db-ad66-4c36-8f5c-b0ecd4f49d84"), "(568) 671-7714", "Claire Brakus" },
                    { new Guid("8e75eb7d-46fd-4d63-85fd-42ebfaff3529"), "341-668-8620 x74750", "Marion Cormier" },
                    { new Guid("c3415adc-b709-4358-832b-a45ceca3b2e3"), "(667) 405-8095 x85917", "Guillermo Braun" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("0911cc26-92b7-402e-851a-2945a9a6a1fe"), "Alan.Jacobi@gmail.com", "Alan Jacobi", "123123123", "1-880-271-9256", "cook", "Employee" },
                    { new Guid("19e13792-b24b-4e0f-a11a-859c9fc3f7c5"), "otabek.pro@hotmail.com", "Otabek Rustamov", "123123123", "267.872.7343 x723", "Developer", "Admin" },
                    { new Guid("6a2710b5-8739-4233-97b8-08bf0fe6a5a9"), "Cedric_Jones@hotmail.com", "Cedric Jones", "123123123", "852.376.3689 x0759", "cook", "Employee" },
                    { new Guid("cf0a1bf9-0e54-4616-959a-161dc1174888"), "Marguerite_Jacobs64@yahoo.com", "Marguerite Jacobs", "123123123", "364.936.8272 x34538", "hr", "Director" },
                    { new Guid("d775f81d-7374-4e9f-8427-2538507b0241"), "Miriam43@hotmail.com", "Miriam Moen", "123123123", "(879) 761-5390", "cook", "Director" },
                    { new Guid("eb484c13-3a38-41dd-80ea-c49bb9a5ed2a"), "Vickie_Greenfelder34@yahoo.com", "Vickie Greenfelder", "123123123", "1-270-444-6993", "security", "Director" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("2af94105-227c-4128-90bb-1923fdb067bc"), "5324-0560-5408-9412", new Guid("4c78d4db-ad66-4c36-8f5c-b0ecd4f49d84"), false, "677" },
                    { new Guid("7c19902d-ccc2-4ffa-abbd-2e1ea574a9d9"), "5893571149843871", new Guid("3e774720-bbe2-48a2-bdd0-a90679f16dd0"), false, "707" },
                    { new Guid("870b1254-e4d7-4274-a4d3-1debd1913deb"), "6763-1729-8504-3174", new Guid("13e4600b-f4da-4296-8dac-4cecadf92997"), false, "175" },
                    { new Guid("9a4dd4b7-c655-4867-845a-6bba3d74ba05"), "3529-4963-9555-2298", new Guid("4a5f5d2d-7da3-4af8-bae3-b2d8b590a1e4"), false, "586" },
                    { new Guid("aba53ab7-dde1-4cce-83ff-e9b5fefe38e9"), "6380-2441-5825-2438", new Guid("8e75eb7d-46fd-4d63-85fd-42ebfaff3529"), false, "309" },
                    { new Guid("ad48eda5-e7b0-420d-babd-179b1e648abe"), "6709591577588526865", new Guid("2716d91f-7a75-4898-921c-946780e3b87e"), false, "498" },
                    { new Guid("c2859a0e-caf7-40cc-9ffb-143f707dc122"), "6376-4264-2188-6904", new Guid("349b38e8-e849-45cb-a176-721782198e5e"), false, "874" },
                    { new Guid("e574de62-8f33-4e98-9e3b-cefdbf6fc089"), "3528-0984-9614-0261", new Guid("c3415adc-b709-4358-832b-a45ceca3b2e3"), false, "681" },
                    { new Guid("e7405a5b-8040-41ea-9399-740dfb6f89fa"), "3556-2936-2649-1206", new Guid("0916b01d-8c68-444d-93f2-337903498924"), false, "409" },
                    { new Guid("fd942634-be23-42e0-91c6-b405bf40ccca"), "3415-929671-84833", new Guid("40398b13-8282-4e8c-9e43-69b823cfbacd"), false, "792" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_History_Employees_EmployeeId",
                table: "History",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Employees_EmployeeId",
                table: "History");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2af94105-227c-4128-90bb-1923fdb067bc"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("7c19902d-ccc2-4ffa-abbd-2e1ea574a9d9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("870b1254-e4d7-4274-a4d3-1debd1913deb"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("9a4dd4b7-c655-4867-845a-6bba3d74ba05"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("aba53ab7-dde1-4cce-83ff-e9b5fefe38e9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ad48eda5-e7b0-420d-babd-179b1e648abe"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c2859a0e-caf7-40cc-9ffb-143f707dc122"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e574de62-8f33-4e98-9e3b-cefdbf6fc089"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e7405a5b-8040-41ea-9399-740dfb6f89fa"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("fd942634-be23-42e0-91c6-b405bf40ccca"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0911cc26-92b7-402e-851a-2945a9a6a1fe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("19e13792-b24b-4e0f-a11a-859c9fc3f7c5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6a2710b5-8739-4233-97b8-08bf0fe6a5a9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cf0a1bf9-0e54-4616-959a-161dc1174888"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d775f81d-7374-4e9f-8427-2538507b0241"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("eb484c13-3a38-41dd-80ea-c49bb9a5ed2a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0916b01d-8c68-444d-93f2-337903498924"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("13e4600b-f4da-4296-8dac-4cecadf92997"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2716d91f-7a75-4898-921c-946780e3b87e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("349b38e8-e849-45cb-a176-721782198e5e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("3e774720-bbe2-48a2-bdd0-a90679f16dd0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("40398b13-8282-4e8c-9e43-69b823cfbacd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4a5f5d2d-7da3-4af8-bae3-b2d8b590a1e4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4c78d4db-ad66-4c36-8f5c-b0ecd4f49d84"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("8e75eb7d-46fd-4d63-85fd-42ebfaff3529"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c3415adc-b709-4358-832b-a45ceca3b2e3"));

            migrationBuilder.AddColumn<Guid>(
                name: "CardId",
                table: "History",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "History",
                type: "uuid",
                nullable: true);

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
                name: "IX_History_CardId",
                table: "History",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_History_CustomerId",
                table: "History",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Cards_CardId",
                table: "History",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Customers_CustomerId",
                table: "History",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Employees_EmployeeId",
                table: "History",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
