using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EasyBank.Migrations
{
    /// <inheritdoc />
    public partial class NewFakeDataWithPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FullName" },
                values: new object[,]
                {
                    { new Guid("66e05fa3-8da3-4728-b294-4a1fb055e295"), "(476) 779-0065 x2009", "Lori Keeling" },
                    { new Guid("6bcb4c45-4bf2-4ff4-b05e-2f17676a0a7a"), "439.256.5821", "Edmund White" },
                    { new Guid("7eb4cf21-7f97-4ae7-84ea-dfa252ebbe85"), "235.528.5297", "Matthew Cremin" },
                    { new Guid("9fb047f9-6092-43ed-ae12-9ec298b7659d"), "(254) 539-1115", "Cecelia Wuckert" },
                    { new Guid("ab87b24b-0035-4dda-81ad-bc464e91f99a"), "530-618-9292 x5350", "Victor Gerlach" },
                    { new Guid("b884a108-f49a-4c3c-af83-31ef089f808b"), "519.315.5130", "Estelle Treutel" },
                    { new Guid("d0853fd5-1fc3-4501-9df3-84d8e0c340dc"), "(828) 739-5336", "Oscar Turcotte" },
                    { new Guid("d2f00749-1aad-4bb7-bee5-e9953d591411"), "(820) 866-2073", "Sharon Feeney" },
                    { new Guid("e934a599-8c86-457b-8576-9a223786c500"), "543-508-9207 x902", "Darrell Goldner" },
                    { new Guid("fb0d1df2-1aca-457b-8ee4-e6bd9bab9b31"), "924-695-5321 x991", "Clint Bergstrom" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FullName", "Password", "Phone", "Position", "Role" },
                values: new object[,]
                {
                    { new Guid("38c98d85-0a35-495d-b3c6-acc2250e4a10"), "Javier_Cormier12@yahoo.com", "Javier Cormier", "$2a$11$p1o9KmakWD9IGZu97sh6UeD7gt93rx0hu3VtJo2R2.v5VfeHMqL.q", "641.421.8462 x42201", "hr", "Admin" },
                    { new Guid("861c7985-2e67-4adb-8917-d44a16b5fe42"), "Cody54@yahoo.com", "Cody Raynor", "$2a$11$VJIG5qW3U1D33NIdwtO0nOL9AHGN1hL93GYyyRvYoNFf4.uNE.cLW", "1-279-340-2977", "developer", "Director" },
                    { new Guid("8ab94934-5169-4081-ae88-4794b089ad15"), "Eula44@gmail.com", "Eula McKenzie", "$2a$11$oIxel7tV9Or8r60kPSk7MeKki11UzrzHzUgwCIRZ3k58FAkqnG7xa", "(931) 248-6062", "cook", "Employee" },
                    { new Guid("adce2acf-42c3-4b41-940a-9163eac458d7"), "Laverne.Moore@yahoo.com", "Laverne Moore", "$2a$11$RnVwM9BnnSh3gF0f0lxD0.GeBGZiBUEfH5fJJ3JAuQPjqcw1IYlLC", "443-926-8632", "developer", "Employee" },
                    { new Guid("c6847f94-cfff-4a00-8662-b3007be9812f"), "otabek.pro@hotmail.com", "Otabek Rustamov", "$2a$11$9fFRvCUDqFQOvjXE6h579eZpnk81mp9KkeHxOi96a0hTTeKviBhNy", "(254) 390-2081 x747", "Developer", "Admin" },
                    { new Guid("ede3bd0a-4bec-4b02-9dcc-612a3d6b9fd9"), "Amy_VonRueden65@gmail.com", "Amy VonRueden", "$2a$11$nZAD3SAkFythDU2OIWOlj.6mDLnHr3b1cjoF7pdNGXif9py2AN1q2", "946-964-7547 x230", "hr", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "CardNumber", "CustomerId", "IsBlocked", "PinCode" },
                values: new object[,]
                {
                    { new Guid("0c944430-c705-4085-8585-8f530413a845"), "6480-6288-6643-9345-6867", new Guid("7eb4cf21-7f97-4ae7-84ea-dfa252ebbe85"), false, "446" },
                    { new Guid("0d4b5fd0-d474-4f35-8918-ee52491c4e8e"), "50386823330515310405", new Guid("d2f00749-1aad-4bb7-bee5-e9953d591411"), false, "517" },
                    { new Guid("2aafb2d1-25ef-439b-a279-8097425faf5f"), "6304-2187-0667-3983", new Guid("66e05fa3-8da3-4728-b294-4a1fb055e295"), false, "916" },
                    { new Guid("3b09dc06-8ecd-453d-8942-87d3efb6c096"), "6767-2072-8098-9832", new Guid("9fb047f9-6092-43ed-ae12-9ec298b7659d"), false, "623" },
                    { new Guid("462a993c-c86c-407e-a946-771c6e2f8188"), "4542097385378", new Guid("e934a599-8c86-457b-8576-9a223786c500"), false, "816" },
                    { new Guid("48eacbde-affc-486d-adca-7e3483d7f54d"), "6709149098468062910", new Guid("ab87b24b-0035-4dda-81ad-bc464e91f99a"), false, "576" },
                    { new Guid("6aef9849-f7f4-4be1-bc43-7fe8eb97fea7"), "4276378993580", new Guid("fb0d1df2-1aca-457b-8ee4-e6bd9bab9b31"), false, "374" },
                    { new Guid("8445e59c-5cc8-4737-8b02-8cb6dedbc53f"), "5020-7683-5012-6600", new Guid("b884a108-f49a-4c3c-af83-31ef089f808b"), false, "967" },
                    { new Guid("97024a54-5f42-4d00-ad2e-f2fdcfc924f2"), "6771151385992933", new Guid("d0853fd5-1fc3-4501-9df3-84d8e0c340dc"), false, "048" },
                    { new Guid("9cc09b7d-f551-4817-a5e7-9a8ce26679fd"), "5181-6122-7850-9882", new Guid("6bcb4c45-4bf2-4ff4-b05e-2f17676a0a7a"), false, "312" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0c944430-c705-4085-8585-8f530413a845"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0d4b5fd0-d474-4f35-8918-ee52491c4e8e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2aafb2d1-25ef-439b-a279-8097425faf5f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("3b09dc06-8ecd-453d-8942-87d3efb6c096"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("462a993c-c86c-407e-a946-771c6e2f8188"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("48eacbde-affc-486d-adca-7e3483d7f54d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("6aef9849-f7f4-4be1-bc43-7fe8eb97fea7"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("8445e59c-5cc8-4737-8b02-8cb6dedbc53f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("97024a54-5f42-4d00-ad2e-f2fdcfc924f2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("9cc09b7d-f551-4817-a5e7-9a8ce26679fd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("38c98d85-0a35-495d-b3c6-acc2250e4a10"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("861c7985-2e67-4adb-8917-d44a16b5fe42"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8ab94934-5169-4081-ae88-4794b089ad15"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("adce2acf-42c3-4b41-940a-9163eac458d7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c6847f94-cfff-4a00-8662-b3007be9812f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ede3bd0a-4bec-4b02-9dcc-612a3d6b9fd9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("66e05fa3-8da3-4728-b294-4a1fb055e295"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("6bcb4c45-4bf2-4ff4-b05e-2f17676a0a7a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7eb4cf21-7f97-4ae7-84ea-dfa252ebbe85"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("9fb047f9-6092-43ed-ae12-9ec298b7659d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("ab87b24b-0035-4dda-81ad-bc464e91f99a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b884a108-f49a-4c3c-af83-31ef089f808b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d0853fd5-1fc3-4501-9df3-84d8e0c340dc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("d2f00749-1aad-4bb7-bee5-e9953d591411"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e934a599-8c86-457b-8576-9a223786c500"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fb0d1df2-1aca-457b-8ee4-e6bd9bab9b31"));

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
        }
    }
}
