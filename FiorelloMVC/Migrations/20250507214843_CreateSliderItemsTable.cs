using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloMVC.Migrations
{
    /// <inheritdoc />
    public partial class CreateSliderItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "SliderItems",
                newName: "Title");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "SliderItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "SliderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "SliderItems");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "SliderItems");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SliderItems",
                newName: "Description");
        }
    }
}
