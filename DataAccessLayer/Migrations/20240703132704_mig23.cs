using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "factsdomainregistered",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "factshappycustomer",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "factshostingsales",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "factsresolvedsupport",
                table: "MainPages",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "factsdomainregistered",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "factshappycustomer",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "factshostingsales",
                table: "MainPages");

            migrationBuilder.DropColumn(
                name: "factsresolvedsupport",
                table: "MainPages");
        }
    }
}
