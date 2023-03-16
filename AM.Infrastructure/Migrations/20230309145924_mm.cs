using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "IdTest2",
                table: "Passengers");

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Passengers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdTest2",
                table: "Passengers",
                type: "int",
                nullable: true);
        }
    }
}
