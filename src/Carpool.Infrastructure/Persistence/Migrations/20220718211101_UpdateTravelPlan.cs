using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    public partial class UpdateTravelPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TravelPlans_CarId",
                table: "TravelPlans");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2acd2627-efdb-4ce5-9897-55622d87ff0c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("30ccac74-314e-4f69-abae-465b486b37f9"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3d78a404-053a-42ee-87fd-18872acffcf5"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5c2a44bc-b78d-41f9-bb78-a1a774f7d160"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("8c9f317a-8e54-4fe8-aba3-2de74816fdd7"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("a0ade0c6-3fee-443e-823d-d7ab33bebcdf"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("b59f57ea-c6fa-4cb8-99fb-91aaf1bda424"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("dc39b9ce-ba3f-4dcd-ad12-be16065b0723"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("ed1c4d6e-2512-42ce-86c4-e07bf2991df6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("fbce413a-7714-47f3-8997-adfcdc508306"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("01a4b19d-a047-44f1-abdb-2c8e78a36713"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("04f2a208-9e6a-408a-9817-26b46d43e76b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("05028259-1207-40a1-96d6-5cfa748e9587"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("12332cd7-a4e0-42ea-bce1-e34ff6d355f0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("19febe99-4b17-4cf2-94a1-bc378d6a8fb3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1afd2675-40d9-4cf8-b491-c6d2874a4374"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2af62f73-74a5-4525-a0ae-266dd675be0a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2d4954b4-01ab-46b0-97a8-cfd9021d9e9a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2fa78dec-8e59-418c-9a33-d8a713eec057"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("41b275ec-3113-4d8d-af64-368532bd8b1f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4eabe42a-3d85-4449-a459-971b3d6196a2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4ecdb655-0f12-46fe-93e4-e1af35eae3a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5a1f8040-7058-4aeb-8fb8-4f842da147d8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5a583697-06ed-40e4-8abb-1d9affb4872a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5dc222b3-d33e-4a9e-be1b-5b6e54284c56"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7a881ff5-a162-435d-935d-6c36cc764196"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("83b6ecd3-03ad-4685-a305-2a551983fead"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("91c7be9c-c124-46eb-b512-c87b60a1dcac"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9646f036-dab9-4a7f-8f24-f2dfa6f4a0e8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a08a6108-201e-4726-9164-e70e2331e27f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c2291347-ffad-4fb1-9b88-269c5a124c78"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e4ce4bce-b32f-4895-b5d8-bbff3bb18894"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e747c491-96e4-4387-a201-45a29e4dc108"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("efbe9f78-b996-4ae6-9279-dfd7cd42fbbb"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f003fdef-3448-4fad-869f-ec07590852e7"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarMakeId", "CarModel", "ColorId", "CreatedAt", "DeletedAt", "Name", "NumberOfSeats", "Plates", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("028b714a-a99d-4010-a517-66a9d309bb14"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null },
                    { new Guid("107eafeb-e5b1-40ae-943f-b4b3fd59f6bb"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("3c121898-4224-40e8-a954-dc9b3166baf3"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("45b3de1d-db38-4ada-9809-50725680db83"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("4a8a761f-e8a7-43b0-bad8-8fb046df6410"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null },
                    { new Guid("4e3db1c6-026c-49f2-baa6-d88349650484"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("53506909-7a19-4372-9cd0-6ed8669f11db"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null },
                    { new Guid("d634c9ad-a6d0-4c84-8b21-bfa509a83be4"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null },
                    { new Guid("d6fdd803-422e-4efd-972d-14fa1e4ee8c1"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("f39aba7f-2fd8-472c-885e-68ef9b312b0c"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmployeeId", "EmployeeName", "IsDriver", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0967125b-b613-40f5-94dc-c261a03a1ded"), null, null, 4, "Thomas Horvar", true, null },
                    { new Guid("0e9e2d16-aa90-4a98-af82-95df91cefcd3"), null, null, 15, "Mario Budimir", true, null },
                    { new Guid("1b445fed-1aee-4eea-bd04-39537f6e4a45"), null, null, 11, "Matej Dušan", false, null },
                    { new Guid("2253dbd8-38e2-423e-937e-76ee954cf560"), null, null, 8, "Dino Jelusić", true, null },
                    { new Guid("2720d594-7f27-415d-a922-f62a0b6bfef3"), null, null, 1, "Ivan Kranjec", true, null },
                    { new Guid("36125da5-b6d4-4928-8cd8-0a3dab3d30dc"), null, null, 2, "Damir Rose", false, null },
                    { new Guid("372b4476-f720-46af-b9be-7b19a1e7a1e6"), null, null, 19, "Lana Jurčević", false, null },
                    { new Guid("3aab8ce3-0439-4b0d-90cb-fb86dae66e0c"), null, null, 21, "Ivan Ivanović", true, null },
                    { new Guid("3e11e441-6b4d-4783-80fe-c0455a35c0ec"), null, null, 22, "Luka Cvrtila", true, null },
                    { new Guid("4d4e5512-930d-4512-98e8-789476eb53ab"), null, null, 16, "Igor Babić", true, null },
                    { new Guid("62d683c3-2b34-4c5c-a9a5-03c33ba165c3"), null, null, 14, "Jasna Gruber", true, null },
                    { new Guid("62e0e61a-b102-4d46-af69-f94cb50584c6"), null, null, 10, "Hrvoje Plenk", true, null },
                    { new Guid("6899b78d-8a6b-488e-8d34-6040dc7dc03f"), null, null, 20, "Mihaela Dubrovnik", false, null },
                    { new Guid("6f9d0505-67e7-4d18-99e6-73bbab6930e2"), null, null, 18, "Melita Huskvarnić", true, null },
                    { new Guid("749331b0-bf19-4101-9f99-d45b7eb62ea7"), null, null, 25, "Nenad Kovaček", true, null },
                    { new Guid("80882380-b2d5-4661-94a3-3c38b60fd425"), null, null, 9, "Miroslav Škoro", true, null },
                    { new Guid("81021dd0-f67f-468f-ba55-f6dc9944d690"), null, null, 7, "Marin Horvat", false, null },
                    { new Guid("a1a74bd5-e651-48c8-b449-e7f1d28dd7d3"), null, null, 12, "Peter Pan", true, null },
                    { new Guid("a2a674e7-2444-4d78-b783-d9f23aeeef69"), null, null, 3, "Ana Lazaric", true, null },
                    { new Guid("a50ad4d3-7888-4322-a8b2-5eaff33505d5"), null, null, 17, "Marija Husar", false, null },
                    { new Guid("ae167c8b-99bc-4152-9658-ce01f2bacd98"), null, null, 24, "Dubravka Martinić", true, null },
                    { new Guid("d1f97fff-2384-4dfe-a19b-188a4d14b553"), null, null, 23, "Dubravko Marček", true, null },
                    { new Guid("db23d11b-052b-4f8a-bf04-4f055a15ca2e"), null, null, 13, "Hrvoje Mirić", true, null },
                    { new Guid("e7d2ce1b-fd6f-4c18-881f-bffd2bca266f"), null, null, 5, "Marko Mlinarić", true, null },
                    { new Guid("fa715e0d-8f49-4480-ba64-55b1315bd3f6"), null, null, 6, "Josip Tandara", true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlans_CarId",
                table: "TravelPlans",
                column: "CarId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TravelPlans_CarId",
                table: "TravelPlans");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("028b714a-a99d-4010-a517-66a9d309bb14"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("107eafeb-e5b1-40ae-943f-b4b3fd59f6bb"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("3c121898-4224-40e8-a954-dc9b3166baf3"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("45b3de1d-db38-4ada-9809-50725680db83"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4a8a761f-e8a7-43b0-bad8-8fb046df6410"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("4e3db1c6-026c-49f2-baa6-d88349650484"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("53506909-7a19-4372-9cd0-6ed8669f11db"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d634c9ad-a6d0-4c84-8b21-bfa509a83be4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d6fdd803-422e-4efd-972d-14fa1e4ee8c1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("f39aba7f-2fd8-472c-885e-68ef9b312b0c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0967125b-b613-40f5-94dc-c261a03a1ded"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0e9e2d16-aa90-4a98-af82-95df91cefcd3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1b445fed-1aee-4eea-bd04-39537f6e4a45"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2253dbd8-38e2-423e-937e-76ee954cf560"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("2720d594-7f27-415d-a922-f62a0b6bfef3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("36125da5-b6d4-4928-8cd8-0a3dab3d30dc"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("372b4476-f720-46af-b9be-7b19a1e7a1e6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3aab8ce3-0439-4b0d-90cb-fb86dae66e0c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("3e11e441-6b4d-4783-80fe-c0455a35c0ec"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4d4e5512-930d-4512-98e8-789476eb53ab"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("62d683c3-2b34-4c5c-a9a5-03c33ba165c3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("62e0e61a-b102-4d46-af69-f94cb50584c6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6899b78d-8a6b-488e-8d34-6040dc7dc03f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6f9d0505-67e7-4d18-99e6-73bbab6930e2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("749331b0-bf19-4101-9f99-d45b7eb62ea7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("80882380-b2d5-4661-94a3-3c38b60fd425"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("81021dd0-f67f-468f-ba55-f6dc9944d690"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a1a74bd5-e651-48c8-b449-e7f1d28dd7d3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a2a674e7-2444-4d78-b783-d9f23aeeef69"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("a50ad4d3-7888-4322-a8b2-5eaff33505d5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("ae167c8b-99bc-4152-9658-ce01f2bacd98"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d1f97fff-2384-4dfe-a19b-188a4d14b553"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("db23d11b-052b-4f8a-bf04-4f055a15ca2e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("e7d2ce1b-fd6f-4c18-881f-bffd2bca266f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fa715e0d-8f49-4480-ba64-55b1315bd3f6"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarMakeId", "CarModel", "ColorId", "CreatedAt", "DeletedAt", "Name", "NumberOfSeats", "Plates", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2acd2627-efdb-4ce5-9897-55622d87ff0c"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null },
                    { new Guid("30ccac74-314e-4f69-abae-465b486b37f9"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null },
                    { new Guid("3d78a404-053a-42ee-87fd-18872acffcf5"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("5c2a44bc-b78d-41f9-bb78-a1a774f7d160"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("8c9f317a-8e54-4fe8-aba3-2de74816fdd7"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("a0ade0c6-3fee-443e-823d-d7ab33bebcdf"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null },
                    { new Guid("b59f57ea-c6fa-4cb8-99fb-91aaf1bda424"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("dc39b9ce-ba3f-4dcd-ad12-be16065b0723"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("ed1c4d6e-2512-42ce-86c4-e07bf2991df6"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null },
                    { new Guid("fbce413a-7714-47f3-8997-adfcdc508306"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmployeeId", "EmployeeName", "IsDriver", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01a4b19d-a047-44f1-abdb-2c8e78a36713"), null, null, 11, "Matej Dušan", false, null },
                    { new Guid("04f2a208-9e6a-408a-9817-26b46d43e76b"), null, null, 15, "Mario Budimir", true, null },
                    { new Guid("05028259-1207-40a1-96d6-5cfa748e9587"), null, null, 21, "Ivan Ivanović", true, null },
                    { new Guid("12332cd7-a4e0-42ea-bce1-e34ff6d355f0"), null, null, 1, "Ivan Kranjec", true, null },
                    { new Guid("19febe99-4b17-4cf2-94a1-bc378d6a8fb3"), null, null, 17, "Marija Husar", false, null },
                    { new Guid("1afd2675-40d9-4cf8-b491-c6d2874a4374"), null, null, 5, "Marko Mlinarić", true, null },
                    { new Guid("2af62f73-74a5-4525-a0ae-266dd675be0a"), null, null, 12, "Peter Pan", true, null },
                    { new Guid("2d4954b4-01ab-46b0-97a8-cfd9021d9e9a"), null, null, 25, "Nenad Kovaček", true, null },
                    { new Guid("2fa78dec-8e59-418c-9a33-d8a713eec057"), null, null, 4, "Thomas Horvar", true, null },
                    { new Guid("41b275ec-3113-4d8d-af64-368532bd8b1f"), null, null, 2, "Damir Rose", false, null },
                    { new Guid("4eabe42a-3d85-4449-a459-971b3d6196a2"), null, null, 22, "Luka Cvrtila", true, null },
                    { new Guid("4ecdb655-0f12-46fe-93e4-e1af35eae3a4"), null, null, 19, "Lana Jurčević", false, null },
                    { new Guid("5a1f8040-7058-4aeb-8fb8-4f842da147d8"), null, null, 3, "Ana Lazaric", true, null },
                    { new Guid("5a583697-06ed-40e4-8abb-1d9affb4872a"), null, null, 6, "Josip Tandara", true, null },
                    { new Guid("5dc222b3-d33e-4a9e-be1b-5b6e54284c56"), null, null, 23, "Dubravko Marček", true, null },
                    { new Guid("7a881ff5-a162-435d-935d-6c36cc764196"), null, null, 16, "Igor Babić", true, null },
                    { new Guid("83b6ecd3-03ad-4685-a305-2a551983fead"), null, null, 13, "Hrvoje Mirić", true, null },
                    { new Guid("91c7be9c-c124-46eb-b512-c87b60a1dcac"), null, null, 20, "Mihaela Dubrovnik", false, null },
                    { new Guid("9646f036-dab9-4a7f-8f24-f2dfa6f4a0e8"), null, null, 24, "Dubravka Martinić", true, null },
                    { new Guid("a08a6108-201e-4726-9164-e70e2331e27f"), null, null, 8, "Dino Jelusić", true, null },
                    { new Guid("c2291347-ffad-4fb1-9b88-269c5a124c78"), null, null, 7, "Marin Horvat", false, null },
                    { new Guid("e4ce4bce-b32f-4895-b5d8-bbff3bb18894"), null, null, 9, "Miroslav Škoro", true, null },
                    { new Guid("e747c491-96e4-4387-a201-45a29e4dc108"), null, null, 10, "Hrvoje Plenk", true, null },
                    { new Guid("efbe9f78-b996-4ae6-9279-dfd7cd42fbbb"), null, null, 18, "Melita Huskvarnić", true, null },
                    { new Guid("f003fdef-3448-4fad-869f-ec07590852e7"), null, null, 14, "Jasna Gruber", true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlans_CarId",
                table: "TravelPlans",
                column: "CarId");
        }
    }
}
