using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    public partial class CountyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("1d0bd5fc-93cd-4e6f-811c-8eceeee27d2e"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("2d1361c3-e104-4dca-acd0-22c6507b8fe4"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5ed2fa8c-c040-45bd-bbc8-857483db990c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("6019784f-aebc-41bd-89e8-491218944f6a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("66cbcce9-0325-4f6a-932e-0fde32817f0c"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("749f55fb-3bdb-4a41-b761-83e0dc04e470"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("93251b81-452d-447c-8097-ddc3cded620f"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("afc4456c-3dd4-4538-a809-56762e7a91d6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("c94194d9-042e-4c73-9dd7-88a45112c2bc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("d3b7c8e3-a58d-4e96-9baa-304f5369aec3"));

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    EmployeeName = table.Column<string>(type: "text", nullable: false),
                    IsDriver = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarMakeId", "CarModel", "ColorId", "CreatedAt", "DeletedAt", "Name", "NumberOfSeats", "Plates", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("05399302-0bf6-4a1c-a134-bb624f844a46"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("0fd94679-86f1-4ec5-8569-df6fcb8b8187"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null },
                    { new Guid("131d447b-5d8d-4b8e-b68c-4f15235087b2"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("23a5f8c3-5981-45e4-b432-7a6e2260c8dc"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("45d3da20-9bc8-4d1e-a71b-0cded82c96b1"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("48727973-b5db-47d6-8f4a-c19e5e89b9a6"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null },
                    { new Guid("5944affc-502c-4290-9296-77f7af1bf66a"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("71af1aab-6795-4750-9fba-a32f7366ca48"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null },
                    { new Guid("eded84c4-50aa-4105-a7d1-5a74ba65a54d"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null },
                    { new Guid("facfdffd-18e3-403e-865b-0a632b3445bc"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, "Bjelovarsko-bilogorska", null },
                    { 2, null, null, "Brodsko-posavska", null },
                    { 3, null, null, "Dubrovačko-neretvanska", null },
                    { 4, null, null, "Istarska", null },
                    { 5, null, null, "Karlovacka", null },
                    { 6, null, null, "Koprivničko-križevačka", null },
                    { 7, null, null, "Krapinsko-zagorska", null },
                    { 8, null, null, "Ličko-senjska", null },
                    { 9, null, null, "Međimurska", null },
                    { 10, null, null, "Osječko-baranjska", null },
                    { 11, null, null, "Požeško-slavonska", null },
                    { 12, null, null, "Primorsko-goranska", null },
                    { 13, null, null, "Sisačko-moslavačka", null },
                    { 14, null, null, "Splitsko-dalmatinska", null },
                    { 15, null, null, "Šibensko-kninska", null },
                    { 16, null, null, "Varaždinska", null },
                    { 17, null, null, "Virovitičko-podravska", null },
                    { 18, null, null, "Vukovarsko-srijemska", null },
                    { 19, null, null, "Zadarska", null },
                    { 20, null, null, "Zagrebačka", null },
                    { 21, null, null, "Grad Zagreb", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmployeeId", "EmployeeName", "IsDriver", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04138783-0645-4b0f-8844-b5543b8579b4"), null, null, 12, "Peter Pan", true, null },
                    { new Guid("191f46ef-c14e-424f-99e8-ea79a4c1c18c"), null, null, 4, "Thomas Horvar", true, null },
                    { new Guid("1c0cc5db-2fcb-47a1-98ad-847b5f246d02"), null, null, 15, "Mario Budimir", true, null },
                    { new Guid("25920735-e3c1-44b9-b111-326fc9398683"), null, null, 22, "Luka Cvrtila", true, null },
                    { new Guid("32f34fd7-5463-4df9-9914-1891792b2c6c"), null, null, 19, "Lana Jurčević", false, null },
                    { new Guid("3ea28d9a-6d48-47ab-aa99-5dab4e53d15f"), null, null, 13, "Hrvoje Mirić", true, null },
                    { new Guid("432febab-0d2e-4e63-abae-e1967e58b712"), null, null, 3, "Ana Lazaric", true, null },
                    { new Guid("5964d5c1-2e5b-48ad-9bf4-0655f70c0a55"), null, null, 9, "Miroslav Škoro", true, null },
                    { new Guid("73267d95-de52-4267-8fe2-e5f970e3152c"), null, null, 8, "Dino Jelusić", true, null },
                    { new Guid("78622a1a-7878-4c70-83b8-b1a6fa01748e"), null, null, 6, "Josip Tandara", true, null },
                    { new Guid("79d4fa81-7ff0-4ba3-bdcc-542a29e144ec"), null, null, 11, "Matej Dušan", false, null },
                    { new Guid("80139e91-6613-48d0-b20f-67266a96dc28"), null, null, 10, "Hrvoje Plenk", true, null },
                    { new Guid("86ff0900-e49c-45e1-9b3a-94e0a0cc9e04"), null, null, 14, "Jasna Gruber", true, null },
                    { new Guid("8aea8956-f3fd-46ea-8597-40b2ebf28199"), null, null, 7, "Marin Horvat", false, null },
                    { new Guid("aa3a9d2e-5836-44ff-88b6-1266f4f252c7"), null, null, 25, "Nenad Kovaček", true, null },
                    { new Guid("aab57b40-261b-4cdb-813c-70cf639405a5"), null, null, 20, "Mihaela Dubrovnik", false, null },
                    { new Guid("ad1efa0d-a2f3-4767-a0d9-dd54bc5a2a23"), null, null, 17, "Marija Husar", false, null },
                    { new Guid("c2ab8ea1-5a41-4f29-8051-8e46f7965974"), null, null, 1, "Ivan Kranjec", true, null },
                    { new Guid("cdf06a97-a5bb-46ae-a056-9bfd07ee61f2"), null, null, 5, "Marko Mlinarić", true, null },
                    { new Guid("d01dd99a-8ffd-43cb-b847-28abab47e2cb"), null, null, 18, "Melita Huskvarnić", true, null },
                    { new Guid("d8a85827-3848-49a3-85ca-ffef9ffe990a"), null, null, 23, "Dubravko Marček", true, null },
                    { new Guid("ee04f5ea-efed-47b2-b837-c7422ab4a591"), null, null, 16, "Igor Babić", true, null },
                    { new Guid("ee10bbef-5161-4f0f-9e82-d24d59f47824"), null, null, 2, "Damir Rose", false, null },
                    { new Guid("f0f1e643-0eac-4548-884c-930cb5347164"), null, null, 21, "Ivan Ivanović", true, null },
                    { new Guid("f88deba0-e6bf-4d33-9beb-cfb925e08fcd"), null, null, 24, "Dubravka Martinić", true, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Counties_Name",
                table: "Counties",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id_EmployeeId",
                table: "Employees",
                columns: new[] { "Id", "EmployeeId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("05399302-0bf6-4a1c-a134-bb624f844a46"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("0fd94679-86f1-4ec5-8569-df6fcb8b8187"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("131d447b-5d8d-4b8e-b68c-4f15235087b2"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("23a5f8c3-5981-45e4-b432-7a6e2260c8dc"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("45d3da20-9bc8-4d1e-a71b-0cded82c96b1"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("48727973-b5db-47d6-8f4a-c19e5e89b9a6"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("5944affc-502c-4290-9296-77f7af1bf66a"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("71af1aab-6795-4750-9fba-a32f7366ca48"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("eded84c4-50aa-4105-a7d1-5a74ba65a54d"));

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: new Guid("facfdffd-18e3-403e-865b-0a632b3445bc"));

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CarMakeId", "CarModel", "ColorId", "CreatedAt", "DeletedAt", "Name", "NumberOfSeats", "Plates", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1d0bd5fc-93cd-4e6f-811c-8eceeee27d2e"), 3, "A5", 10, null, null, "Ivan's Auid", 3, "PU-333-DB", null },
                    { new Guid("2d1361c3-e104-4dca-acd0-22c6507b8fe4"), 4, "Leon", 2, null, null, "Lana's Seat", 5, "KC-222-DA", null },
                    { new Guid("5ed2fa8c-c040-45bd-bbc8-857483db990c"), 8, "Sandero", 3, null, null, "Silvija's Dacia", 5, "NA-221-IA", null },
                    { new Guid("6019784f-aebc-41bd-89e8-491218944f6a"), 10, "V60", 3, null, null, "Patricia's Volvo", 5, "DU-555-PP", null },
                    { new Guid("66cbcce9-0325-4f6a-932e-0fde32817f0c"), 2, "Golf VIII", 1, null, null, "Milan's Golf", 5, "BJ-513-DD", null },
                    { new Guid("749f55fb-3bdb-4a41-b761-83e0dc04e470"), 6, "SX4", 6, null, null, "Tomislav's Suzuki", 5, "B-444-AA", null },
                    { new Guid("93251b81-452d-447c-8097-ddc3cded620f"), 7, "Captiva", 7, null, null, "Nebojsa's Chevy", 5, "RI-6776-DU", null },
                    { new Guid("afc4456c-3dd4-4538-a809-56762e7a91d6"), 5, "Supra", 4, null, null, "Josip's Toyota", 3, "PU-2224-DC", null },
                    { new Guid("c94194d9-042e-4c73-9dd7-88a45112c2bc"), 9, "Mustang", 9, null, null, "John's Mustang", 3, "ZG-5220-IG", null },
                    { new Guid("d3b7c8e3-a58d-4e96-9baa-304f5369aec3"), 1, "Superb", 8, null, null, "Damir's Skoda", 5, "ST-555-BD", null }
                });
        }
    }
}
