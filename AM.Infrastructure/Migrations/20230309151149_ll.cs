using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employementDate",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "function",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "healthInfomation",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "nationality",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Passengers");

            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Passengers",
                newName: "FullName_FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "FullName_FirstName",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "staffs",
                columns: table => new
                {
                    passportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    employementDate = table.Column<DateTime>(type: "date", nullable: false),
                    function = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    salary = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffs", x => x.passportNumber);
                    table.ForeignKey(
                        name: "FK_staffs_Passengers_passportNumber",
                        column: x => x.passportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Travllers",
                columns: table => new
                {
                    passportNumber = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    healthInfomation = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    nationality = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travllers", x => x.passportNumber);
                    table.ForeignKey(
                        name: "FK_Travllers_Passengers_passportNumber",
                        column: x => x.passportNumber,
                        principalTable: "Passengers",
                        principalColumn: "passportNumber",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "staffs");

            migrationBuilder.DropTable(
                name: "Travllers");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Passengers",
                newName: "lastname");

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddColumn<DateTime>(
                name: "employementDate",
                table: "Passengers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "function",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "healthInfomation",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationality",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "salary",
                table: "Passengers",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
