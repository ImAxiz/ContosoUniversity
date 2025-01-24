using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContosoUniversity.Migrations
{
    /// <inheritdoc />
    public partial class lalal123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "NicotineNeeded",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "WorkYears",
                table: "Instructor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Birthday",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NicotineNeeded",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkYears",
                table: "Instructor",
                type: "int",
                nullable: true);
        }
    }
}
