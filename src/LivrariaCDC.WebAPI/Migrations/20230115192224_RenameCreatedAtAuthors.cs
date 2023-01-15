using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LivrariaCDC.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameCreatedAtAuthors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDateTime",
                table: "Authors",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Authors",
                newName: "CreatedDateTime");
        }
    }
}
