using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksLibrary.Migrations
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Costomers_CustomerId",
                table: "BookLoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Costomers",
                table: "Costomers");

            migrationBuilder.RenameTable(
                name: "Costomers",
                newName: "Customers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Customers_CustomerId",
                table: "BookLoans",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Customers_CustomerId",
                table: "BookLoans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Costomers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Costomers",
                table: "Costomers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Costomers_CustomerId",
                table: "BookLoans",
                column: "CustomerId",
                principalTable: "Costomers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
