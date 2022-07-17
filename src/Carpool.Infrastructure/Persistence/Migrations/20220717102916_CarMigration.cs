using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carpool.Infrastructure.Persistence.Migrations
{
    public partial class CarMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Color",
                table: "Color");

            migrationBuilder.RenameTable(
                name: "Color",
                newName: "Colors");

            migrationBuilder.RenameIndex(
                name: "IX_Color_Name",
                table: "Colors",
                newName: "IX_Colors_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CarMakeId = table.Column<int>(type: "integer", nullable: false),
                    CarModel = table.Column<string>(type: "text", nullable: false),
                    ColorId = table.Column<int>(type: "integer", nullable: false),
                    Plates = table.Column<string>(type: "text", nullable: false),
                    NumberOfSeats = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarMakes_CarMakeId",
                        column: x => x.CarMakeId,
                        principalTable: "CarMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarMakeId",
                table: "Cars",
                column: "CarMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_Plates",
                table: "Cars",
                column: "Plates",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "Color");

            migrationBuilder.RenameIndex(
                name: "IX_Colors_Name",
                table: "Color",
                newName: "IX_Color_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Color",
                table: "Color",
                column: "Id");
        }
    }
}
