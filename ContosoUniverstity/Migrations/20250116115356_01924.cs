using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class _01924 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sugu",
                table: "Instructor");

            migrationBuilder.RenameColumn(
                name: "Vanus",
                table: "Instructor",
                newName: "WorkYears");

            migrationBuilder.RenameColumn(
                name: "Linn",
                table: "Instructor",
                newName: "NicotineNeeded");

            migrationBuilder.AddColumn<int>(
                name: "Birthday",
                table: "Instructor",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Instructor");

            migrationBuilder.RenameColumn(
                name: "WorkYears",
                table: "Instructor",
                newName: "Vanus");

            migrationBuilder.RenameColumn(
                name: "NicotineNeeded",
                table: "Instructor",
                newName: "Linn");

            migrationBuilder.AddColumn<string>(
                name: "Sugu",
                table: "Instructor",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
