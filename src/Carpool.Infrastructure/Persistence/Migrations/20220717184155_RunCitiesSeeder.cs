using System;
using Carpool.Infrastructure.Common;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    public partial class RunCitiesSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            MigrationUtility.RunSqlScript(migrationBuilder, "20220717184155_RunDownCitiesSeeder");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1ec0656a-2eaa-4ea0-94e1-e84c236732ce"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("21e3fbb8-3383-450a-a02f-7830f37f6975"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("289a2dce-3858-4060-a578-e856bbe9a496"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("47b92939-e542-4963-8d28-68265762bc15"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("557366e0-238a-4cc6-84e7-48e2a9f8d8ef"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6c311c66-2501-4bb8-b276-f418ba78eec8"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("71944b4a-b474-49b5-a332-7a4bc07af34b"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("71aa9e1f-5313-4de8-a32f-c2a4420177e8"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("741d71a2-4e8e-4394-9d0f-727e110d9a3d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7f944971-0e54-47e6-a8d8-9a26b55a3cb7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0039467f-4a53-46fd-ba83-0f0536b2a2cf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0415fd77-243e-4617-aed9-25a6d9d872f5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("096a4147-7a49-4ca5-af42-17c08e543c20"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0e1ed9d6-dd4d-48bb-ba5e-30bf0dd7f34a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("148b0ce6-d7be-4aee-8af2-8d16e735c88e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("267cc7cd-a9e8-4490-8e20-33c0a2924bcd"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3368e78e-7260-4d00-9ce2-f36bea75e3ed"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("369994a8-1bfe-482f-8f02-c3414fe3e49d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("36d755c9-9d4c-4312-9eef-be92b09d515b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3718b8d3-a638-494b-9d73-be4e45215421"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3f87b67e-ab69-4c7a-9724-fe42674300db"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("42120578-5e4a-4195-818e-0d158798cab3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("484cd03a-4075-4331-90c3-12af389a94c3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5a4a4b24-4aa4-4948-8e6e-d6a6c4b6f07c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("631912b0-f192-43ec-bdb9-48e2febdbd8d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("67afc62c-ca88-458f-b103-b7323f285239"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6e3311b5-cb1e-4d03-9f21-0b68991c3d87"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("90f41d56-9992-4e72-810b-717c89effbab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a2546620-c3dd-4864-9f6a-8d11be5a7e69"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a705f29a-8925-43ec-ab57-6f3e14789241"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b532263a-0f50-44d2-804a-2f842226582b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d96f383d-3361-4df7-830a-10a35c13e159"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("de2a7d10-c6eb-45e1-9bd1-a90fe3315f6a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("efe4eea0-cdfe-47e0-bd70-0e2749cc24b2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f32f8fef-c8e7-4230-948c-b43e6eebbae6"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarMakeId", "CarModel", "ColorId", "CreatedAt", "DeletedAt", "Name", "NumberOfSeats", "Plates", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16b94982-d53d-46c4-988a-28e0d067144e"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("7f645e8f-6d70-4c6f-8c26-8ab086d6d090"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("9f4b727c-2fb2-47f8-a144-9ae44dc7fd0e"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null },
                    { new Guid("a2bffa7b-f8b4-418e-b025-9f1d6a721836"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null },
                    { new Guid("a408f344-9089-425a-aa2d-9b19a57d456c"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null },
                    { new Guid("aa71e878-65e1-433f-82c2-ead76ae54dc2"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("afb2cfd7-0a2c-4a94-8a5d-940dae9de89d"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null },
                    { new Guid("b699b060-db26-4353-972b-a6b657ea7acc"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("d5c08ae4-8fea-4335-927d-61cbbcc74c5d"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("fe37d357-0315-419d-9ec8-703becdbc3a4"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmployeeId", "EmployeeName", "IsDriver", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0cbec616-ee1f-40a1-bf63-7311cb843d47"), null, null, 14, "Jasna Gruber", true, null },
                    { new Guid("1aa38154-d60f-46df-921c-a19cd6acc01e"), null, null, 9, "Miroslav Škoro", true, null },
                    { new Guid("1eaefffd-6892-4d5c-8790-c5c3bf402f6e"), null, null, 23, "Dubravko Marček", true, null },
                    { new Guid("2eca242a-aa01-4e7f-a5a2-bacf82276543"), null, null, 12, "Peter Pan", true, null },
                    { new Guid("4a09509a-931f-4337-b7b0-34eaba5582ab"), null, null, 3, "Ana Lazaric", true, null },
                    { new Guid("52cf73ac-0f26-4fc1-8ac0-725122042f17"), null, null, 18, "Melita Huskvarnić", true, null },
                    { new Guid("53e0cfa6-e244-407f-aaa6-bf29af321adf"), null, null, 5, "Marko Mlinarić", true, null },
                    { new Guid("62ec7789-d849-4e2e-b690-aab3df1ef939"), null, null, 25, "Nenad Kovaček", true, null },
                    { new Guid("64bdff26-9e14-4ab4-a87b-e5a82d712e5d"), null, null, 21, "Ivan Ivanović", true, null },
                    { new Guid("7115789c-ed56-478a-b1db-546b4e2828f8"), null, null, 17, "Marija Husar", false, null },
                    { new Guid("76d53678-4760-41b1-a1a0-0dd8ce7685d5"), null, null, 15, "Mario Budimir", true, null },
                    { new Guid("8102a731-b943-4bbf-946b-85180eee4bc1"), null, null, 8, "Dino Jelusić", true, null },
                    { new Guid("99469e79-ced5-4a40-b16e-ddaceb33a95d"), null, null, 13, "Hrvoje Mirić", true, null },
                    { new Guid("a2838c0a-f113-4b50-bf99-78e0c411a9ea"), null, null, 1, "Ivan Kranjec", true, null },
                    { new Guid("a4a1d54f-f4fc-4a84-b9fa-7c22de45a3db"), null, null, 11, "Matej Dušan", false, null },
                    { new Guid("ae781d44-1fd0-4076-bcf1-278a04c1cfb5"), null, null, 4, "Thomas Horvar", true, null },
                    { new Guid("d68ec4e2-7333-44ad-9e17-f48756d33ef0"), null, null, 24, "Dubravka Martinić", true, null },
                    { new Guid("d81bd701-dc13-4d43-ae4d-385e2a753452"), null, null, 20, "Mihaela Dubrovnik", false, null },
                    { new Guid("df92b26b-8861-4a62-b095-cec8d48f3770"), null, null, 19, "Lana Jurčević", false, null },
                    { new Guid("e4bc71ce-6e58-463a-a0d0-27224a423580"), null, null, 10, "Hrvoje Plenk", true, null },
                    { new Guid("e661a87f-f1c5-46b5-b79c-9806b3c54ec4"), null, null, 2, "Damir Rose", false, null },
                    { new Guid("f092be95-20e2-48a9-b034-5c089ca8ec03"), null, null, 22, "Luka Cvrtila", true, null },
                    { new Guid("f8ebd6aa-a132-486a-90d8-966bd775cda4"), null, null, 16, "Igor Babić", true, null },
                    { new Guid("f9745ec4-6b55-4162-889f-65868976ebf9"), null, null, 7, "Marin Horvat", false, null },
                    { new Guid("fda3363a-9796-46ff-9871-6e1bded9eb8c"), null, null, 6, "Josip Tandara", true, null }
                });

            MigrationUtility.RunSqlScript(migrationBuilder, "20220717184155_RunCitiesSeeder");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            MigrationUtility.RunSqlScript(migrationBuilder, "20220717184155_RunDownCitiesSeeder");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("16b94982-d53d-46c4-988a-28e0d067144e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("7f645e8f-6d70-4c6f-8c26-8ab086d6d090"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("9f4b727c-2fb2-47f8-a144-9ae44dc7fd0e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a2bffa7b-f8b4-418e-b025-9f1d6a721836"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a408f344-9089-425a-aa2d-9b19a57d456c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("aa71e878-65e1-433f-82c2-ead76ae54dc2"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("afb2cfd7-0a2c-4a94-8a5d-940dae9de89d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b699b060-db26-4353-972b-a6b657ea7acc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d5c08ae4-8fea-4335-927d-61cbbcc74c5d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("fe37d357-0315-419d-9ec8-703becdbc3a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0cbec616-ee1f-40a1-bf63-7311cb843d47"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1aa38154-d60f-46df-921c-a19cd6acc01e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1eaefffd-6892-4d5c-8790-c5c3bf402f6e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2eca242a-aa01-4e7f-a5a2-bacf82276543"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4a09509a-931f-4337-b7b0-34eaba5582ab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("52cf73ac-0f26-4fc1-8ac0-725122042f17"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("53e0cfa6-e244-407f-aaa6-bf29af321adf"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("62ec7789-d849-4e2e-b690-aab3df1ef939"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("64bdff26-9e14-4ab4-a87b-e5a82d712e5d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7115789c-ed56-478a-b1db-546b4e2828f8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("76d53678-4760-41b1-a1a0-0dd8ce7685d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8102a731-b943-4bbf-946b-85180eee4bc1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("99469e79-ced5-4a40-b16e-ddaceb33a95d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a2838c0a-f113-4b50-bf99-78e0c411a9ea"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a4a1d54f-f4fc-4a84-b9fa-7c22de45a3db"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ae781d44-1fd0-4076-bcf1-278a04c1cfb5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d68ec4e2-7333-44ad-9e17-f48756d33ef0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d81bd701-dc13-4d43-ae4d-385e2a753452"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("df92b26b-8861-4a62-b095-cec8d48f3770"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e4bc71ce-6e58-463a-a0d0-27224a423580"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e661a87f-f1c5-46b5-b79c-9806b3c54ec4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f092be95-20e2-48a9-b034-5c089ca8ec03"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f8ebd6aa-a132-486a-90d8-966bd775cda4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f9745ec4-6b55-4162-889f-65868976ebf9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fda3363a-9796-46ff-9871-6e1bded9eb8c"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarMakeId", "CarModel", "ColorId", "CreatedAt", "DeletedAt", "Name", "NumberOfSeats", "Plates", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ec0656a-2eaa-4ea0-94e1-e84c236732ce"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("21e3fbb8-3383-450a-a02f-7830f37f6975"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null },
                    { new Guid("289a2dce-3858-4060-a578-e856bbe9a496"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null },
                    { new Guid("47b92939-e542-4963-8d28-68265762bc15"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null },
                    { new Guid("557366e0-238a-4cc6-84e7-48e2a9f8d8ef"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("6c311c66-2501-4bb8-b276-f418ba78eec8"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("71944b4a-b474-49b5-a332-7a4bc07af34b"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("71aa9e1f-5313-4de8-a32f-c2a4420177e8"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null },
                    { new Guid("741d71a2-4e8e-4394-9d0f-727e110d9a3d"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("7f944971-0e54-47e6-a8d8-9a26b55a3cb7"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmployeeId", "EmployeeName", "IsDriver", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0039467f-4a53-46fd-ba83-0f0536b2a2cf"), null, null, 1, "Ivan Kranjec", true, null },
                    { new Guid("0415fd77-243e-4617-aed9-25a6d9d872f5"), null, null, 20, "Mihaela Dubrovnik", false, null },
                    { new Guid("096a4147-7a49-4ca5-af42-17c08e543c20"), null, null, 14, "Jasna Gruber", true, null },
                    { new Guid("0e1ed9d6-dd4d-48bb-ba5e-30bf0dd7f34a"), null, null, 13, "Hrvoje Mirić", true, null },
                    { new Guid("148b0ce6-d7be-4aee-8af2-8d16e735c88e"), null, null, 7, "Marin Horvat", false, null },
                    { new Guid("267cc7cd-a9e8-4490-8e20-33c0a2924bcd"), null, null, 3, "Ana Lazaric", true, null },
                    { new Guid("3368e78e-7260-4d00-9ce2-f36bea75e3ed"), null, null, 25, "Nenad Kovaček", true, null },
                    { new Guid("369994a8-1bfe-482f-8f02-c3414fe3e49d"), null, null, 24, "Dubravka Martinić", true, null },
                    { new Guid("36d755c9-9d4c-4312-9eef-be92b09d515b"), null, null, 12, "Peter Pan", true, null },
                    { new Guid("3718b8d3-a638-494b-9d73-be4e45215421"), null, null, 5, "Marko Mlinarić", true, null },
                    { new Guid("3f87b67e-ab69-4c7a-9724-fe42674300db"), null, null, 8, "Dino Jelusić", true, null },
                    { new Guid("42120578-5e4a-4195-818e-0d158798cab3"), null, null, 23, "Dubravko Marček", true, null },
                    { new Guid("484cd03a-4075-4331-90c3-12af389a94c3"), null, null, 18, "Melita Huskvarnić", true, null },
                    { new Guid("5a4a4b24-4aa4-4948-8e6e-d6a6c4b6f07c"), null, null, 2, "Damir Rose", false, null },
                    { new Guid("631912b0-f192-43ec-bdb9-48e2febdbd8d"), null, null, 10, "Hrvoje Plenk", true, null },
                    { new Guid("67afc62c-ca88-458f-b103-b7323f285239"), null, null, 19, "Lana Jurčević", false, null },
                    { new Guid("6e3311b5-cb1e-4d03-9f21-0b68991c3d87"), null, null, 22, "Luka Cvrtila", true, null },
                    { new Guid("90f41d56-9992-4e72-810b-717c89effbab"), null, null, 17, "Marija Husar", false, null },
                    { new Guid("a2546620-c3dd-4864-9f6a-8d11be5a7e69"), null, null, 16, "Igor Babić", true, null },
                    { new Guid("a705f29a-8925-43ec-ab57-6f3e14789241"), null, null, 9, "Miroslav Škoro", true, null },
                    { new Guid("b532263a-0f50-44d2-804a-2f842226582b"), null, null, 6, "Josip Tandara", true, null },
                    { new Guid("d96f383d-3361-4df7-830a-10a35c13e159"), null, null, 11, "Matej Dušan", false, null },
                    { new Guid("de2a7d10-c6eb-45e1-9bd1-a90fe3315f6a"), null, null, 4, "Thomas Horvar", true, null },
                    { new Guid("efe4eea0-cdfe-47e0-bd70-0e2749cc24b2"), null, null, 21, "Ivan Ivanović", true, null },
                    { new Guid("f32f8fef-c8e7-4230-948c-b43e6eebbae6"), null, null, 15, "Mario Budimir", true, null }
                });

            MigrationUtility.RunSqlScript(migrationBuilder, "20220717184155_RunCitiesSeeder");
        }
    }
}
