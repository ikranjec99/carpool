using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    public partial class CountyMigrationTypoFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("110ed0f4-0952-444b-b956-6643d1b92f6c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1707e43f-9592-4278-9e41-3c8bda6bfd43"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4bc3759c-8be0-4873-9b43-ada35ee25468"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6b1fcac3-d724-4279-b3ae-8bdab543e152"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("725b8890-dbd8-4c92-bdc9-3b8a4dde60ec"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a210d466-baa8-4a0a-85d6-4aaece761eff"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("cdaf5a1c-5526-4108-bc87-4fb87864770b"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d4293b9f-b99b-4058-b75b-708fd19a0eea"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d5a11759-df92-42d0-8871-7cc94c0bbddc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("deec37b8-3b63-4275-86ce-5f6c71590018"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("02abe1ba-03f1-493b-8177-9aaf500e89c8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("06086a5d-2208-4502-91eb-aace40b6dbf0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1cf25a55-410a-42b1-9762-a014615e0470"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1d7c83a4-dd34-41f8-83d0-1d543d525534"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1f456377-b50f-4f01-a91c-881b9e742390"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2c2d2438-f888-43ac-83c4-59cd259a706e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("41a016ef-5928-4127-b11f-874068c23296"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("45a4402f-a7af-49c1-be1c-33e90243b79b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4a0b971a-8638-4f6f-ac1f-6e9cf000e83d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4ad022e2-d33b-4b16-9712-30f9a585e6f0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4aefb4ef-de24-4d80-986b-62d2292b11d7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5c812862-3a42-4493-b26f-7bbc366317c4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("615a1d27-a5c4-44e8-b500-b9c9c95754f7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6b04cdea-0af0-4123-a5a7-66ef90e28936"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7fdc6c06-73b1-44bb-a347-3e431f7f9569"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8116a5d2-c6e3-43e5-8125-ea0e2ac5817f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("857ef14e-db20-4e40-a295-ece2c22df69d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("85874b11-1272-47d9-bdc9-e9c8d494c5c8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8e937d63-2d34-4492-a78d-1eece2ae96b4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("959f1cd3-4a66-40fa-9418-693c2b47cafe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a5133676-669e-49b5-8bbc-fff72304157b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bd4187d7-77dc-464f-b14a-b989911a78d8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c257a5f5-ae8d-44fc-9521-be434ca68aef"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cba5a831-0b63-40a9-a870-ea0fd3a24a6a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ccfa133b-8690-40db-b8de-8391eda3d206"));

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

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Karlovačka");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("110ed0f4-0952-444b-b956-6643d1b92f6c"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null },
                    { new Guid("1707e43f-9592-4278-9e41-3c8bda6bfd43"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("4bc3759c-8be0-4873-9b43-ada35ee25468"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null },
                    { new Guid("6b1fcac3-d724-4279-b3ae-8bdab543e152"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null },
                    { new Guid("725b8890-dbd8-4c92-bdc9-3b8a4dde60ec"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null },
                    { new Guid("a210d466-baa8-4a0a-85d6-4aaece761eff"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("cdaf5a1c-5526-4108-bc87-4fb87864770b"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("d4293b9f-b99b-4058-b75b-708fd19a0eea"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("d5a11759-df92-42d0-8871-7cc94c0bbddc"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("deec37b8-3b63-4275-86ce-5f6c71590018"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null }
                });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Karlovacka");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmployeeId", "EmployeeName", "IsDriver", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02abe1ba-03f1-493b-8177-9aaf500e89c8"), null, null, 2, "Damir Rose", false, null },
                    { new Guid("06086a5d-2208-4502-91eb-aace40b6dbf0"), null, null, 20, "Mihaela Dubrovnik", false, null },
                    { new Guid("1cf25a55-410a-42b1-9762-a014615e0470"), null, null, 19, "Lana Jurčević", false, null },
                    { new Guid("1d7c83a4-dd34-41f8-83d0-1d543d525534"), null, null, 25, "Nenad Kovaček", true, null },
                    { new Guid("1f456377-b50f-4f01-a91c-881b9e742390"), null, null, 10, "Hrvoje Plenk", true, null },
                    { new Guid("2c2d2438-f888-43ac-83c4-59cd259a706e"), null, null, 4, "Thomas Horvar", true, null },
                    { new Guid("41a016ef-5928-4127-b11f-874068c23296"), null, null, 24, "Dubravka Martinić", true, null },
                    { new Guid("45a4402f-a7af-49c1-be1c-33e90243b79b"), null, null, 15, "Mario Budimir", true, null },
                    { new Guid("4a0b971a-8638-4f6f-ac1f-6e9cf000e83d"), null, null, 14, "Jasna Gruber", true, null },
                    { new Guid("4ad022e2-d33b-4b16-9712-30f9a585e6f0"), null, null, 13, "Hrvoje Mirić", true, null },
                    { new Guid("4aefb4ef-de24-4d80-986b-62d2292b11d7"), null, null, 23, "Dubravko Marček", true, null },
                    { new Guid("5c812862-3a42-4493-b26f-7bbc366317c4"), null, null, 18, "Melita Huskvarnić", true, null },
                    { new Guid("615a1d27-a5c4-44e8-b500-b9c9c95754f7"), null, null, 17, "Marija Husar", false, null },
                    { new Guid("6b04cdea-0af0-4123-a5a7-66ef90e28936"), null, null, 16, "Igor Babić", true, null },
                    { new Guid("7fdc6c06-73b1-44bb-a347-3e431f7f9569"), null, null, 1, "Ivan Kranjec", true, null },
                    { new Guid("8116a5d2-c6e3-43e5-8125-ea0e2ac5817f"), null, null, 7, "Marin Horvat", false, null },
                    { new Guid("857ef14e-db20-4e40-a295-ece2c22df69d"), null, null, 12, "Peter Pan", true, null },
                    { new Guid("85874b11-1272-47d9-bdc9-e9c8d494c5c8"), null, null, 6, "Josip Tandara", true, null },
                    { new Guid("8e937d63-2d34-4492-a78d-1eece2ae96b4"), null, null, 3, "Ana Lazaric", true, null },
                    { new Guid("959f1cd3-4a66-40fa-9418-693c2b47cafe"), null, null, 11, "Matej Dušan", false, null },
                    { new Guid("a5133676-669e-49b5-8bbc-fff72304157b"), null, null, 21, "Ivan Ivanović", true, null },
                    { new Guid("bd4187d7-77dc-464f-b14a-b989911a78d8"), null, null, 9, "Miroslav Škoro", true, null },
                    { new Guid("c257a5f5-ae8d-44fc-9521-be434ca68aef"), null, null, 8, "Dino Jelusić", true, null },
                    { new Guid("cba5a831-0b63-40a9-a870-ea0fd3a24a6a"), null, null, 5, "Marko Mlinarić", true, null },
                    { new Guid("ccfa133b-8690-40db-b8de-8391eda3d206"), null, null, 22, "Luka Cvrtila", true, null }
                });
        }
    }
}
