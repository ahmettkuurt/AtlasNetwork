using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_mainpage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamAppellation",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "TeamImage",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "TeamName",
                table: "MainPages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamAppellation",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamImage",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
