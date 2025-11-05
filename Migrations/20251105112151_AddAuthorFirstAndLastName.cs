using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pricope_Delia_L2.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorFirstAndLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Author_AuthorID",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_AuthorID",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "AuthorID",
                table: "Author");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Author",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Author");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Author",
                newName: "AuthorName");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Author_AuthorID",
                table: "Author",
                column: "AuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Author_AuthorID",
                table: "Author",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID");
        }
    }
}
