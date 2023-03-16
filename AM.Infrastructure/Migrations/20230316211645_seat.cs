using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "planeId",
                table: "Passengers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    IdSection = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.IdSection);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    PlaneFk = table.Column<int>(type: "int", nullable: false),
                    SectionFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatId);
                    table.ForeignKey(
                        name: "FK_Seats_Planes_PlaneFk",
                        column: x => x.PlaneFk,
                        principalTable: "Planes",
                        principalColumn: "planeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seats_Sections_SectionFk",
                        column: x => x.SectionFk,
                        principalTable: "Sections",
                        principalColumn: "IdSection",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    DateReservation = table.Column<DateTime>(type: "date", nullable: false),
                    PassengerFk = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    SeatFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.PassengerFk, x.SeatFk, x.DateReservation });
                    table.ForeignKey(
                        name: "FK_Reservations_Passengers_PassengerFk",
                        column: x => x.PassengerFk,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Seats_SeatFk",
                        column: x => x.SeatFk,
                        principalTable: "Seats",
                        principalColumn: "SeatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_planeId",
                table: "Passengers",
                column: "planeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SeatFk",
                table: "Reservations",
                column: "SeatFk");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_PlaneFk",
                table: "Seats",
                column: "PlaneFk");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_SectionFk",
                table: "Seats",
                column: "SectionFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Planes_planeId",
                table: "Passengers",
                column: "planeId",
                principalTable: "Planes",
                principalColumn: "planeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Planes_planeId",
                table: "Passengers");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_planeId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "planeId",
                table: "Passengers");
        }
    }
}
