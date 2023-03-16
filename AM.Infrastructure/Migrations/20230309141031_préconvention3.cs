using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class préconvention3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Passengers",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Passengers",
                newName: "FullName_FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Passengers",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Passengers",
                newName: "firstName");
        }
    }
}
