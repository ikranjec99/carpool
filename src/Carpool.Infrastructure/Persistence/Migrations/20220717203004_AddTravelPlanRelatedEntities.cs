using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    public partial class AddTravelPlanRelatedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "TravelPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CarId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelPlans_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelPlanEmployees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TravelPlanId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlanEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelPlanEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelPlanEmployees_TravelPlans_TravelPlanId",
                        column: x => x.TravelPlanId,
                        principalTable: "TravelPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelPlanEndLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    TravelPlanId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlanEndLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelPlanEndLocations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelPlanEndLocations_TravelPlans_TravelPlanId",
                        column: x => x.TravelPlanId,
                        principalTable: "TravelPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelPlanStartLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    TravelPlanId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelPlanStartLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelPlanStartLocations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelPlanStartLocations_TravelPlans_TravelPlanId",
                        column: x => x.TravelPlanId,
                        principalTable: "TravelPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_TravelPlanEmployees_EmployeeId",
                table: "TravelPlanEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlanEmployees_TravelPlanId",
                table: "TravelPlanEmployees",
                column: "TravelPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlanEndLocations_CityId",
                table: "TravelPlanEndLocations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlanEndLocations_TravelPlanId",
                table: "TravelPlanEndLocations",
                column: "TravelPlanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlans_CarId",
                table: "TravelPlans",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlanStartLocations_CityId",
                table: "TravelPlanStartLocations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelPlanStartLocations_TravelPlanId",
                table: "TravelPlanStartLocations",
                column: "TravelPlanId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravelPlanEmployees");

            migrationBuilder.DropTable(
                name: "TravelPlanEndLocations");

            migrationBuilder.DropTable(
                name: "TravelPlanStartLocations");

            migrationBuilder.DropTable(
                name: "TravelPlans");

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
        }
    }
}
