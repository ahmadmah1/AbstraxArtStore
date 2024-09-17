using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbstraxArtStore.Migrations
{
    /// <inheritdoc />
    public partial class Images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Product",
                type: "nvarchar(255)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "Product",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
