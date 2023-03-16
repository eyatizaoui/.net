using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ok : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "My Resevation");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Prix = table.Column<double>(type: "float", nullable: false),
                    FlightFk = table.Column<int>(type: "int", nullable: false),
                    passengerFk = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Siege = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    flightId = table.Column<int>(type: "int", nullable: false),
                    passengerpassportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.passengerFk, x.FlightFk, x.Prix });
                    table.ForeignKey(
                        name: "FK_Ticket_MyFlight_flightId",
                        column: x => x.flightId,
                        principalTable: "MyFlight",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_passengerpassportNumber",
                        column: x => x.passengerpassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_flightId",
                table: "Ticket",
                column: "flightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_passengerpassportNumber",
                table: "Ticket",
                column: "passengerpassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.CreateTable(
                name: "My Resevation",
                columns: table => new
                {
                    flightsflightId = table.Column<int>(type: "int", nullable: false),
                    passengerspassportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My Resevation", x => new { x.flightsflightId, x.passengerspassportNumber });
                    table.ForeignKey(
                        name: "FK_My Resevation_MyFlight_flightsflightId",
                        column: x => x.flightsflightId,
                        principalTable: "MyFlight",
                        principalColumn: "flightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_My Resevation_Passengers_passengerspassportNumber",
                        column: x => x.passengerspassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_My Resevation_passengerspassportNumber",
                table: "My Resevation",
                column: "passengerspassportNumber");
        }
    }
}
