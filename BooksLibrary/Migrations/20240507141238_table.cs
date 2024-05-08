using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksLibrary.Migrations
{
    /// <inheritdoc />
    public partial class table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CostomerName",
                table: "Costomers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CostomerId",
                table: "Costomers",
                newName: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Costomers",
                newName: "CostomerName");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Costomers",
                newName: "CostomerId");
        }
    }
}
