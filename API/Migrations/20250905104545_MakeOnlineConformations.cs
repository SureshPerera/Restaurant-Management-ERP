using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MakeOnlineConformations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Conformation",
                table: "OnlineBookingModels",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Conformation",
                table: "DirectBookingModels",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Conformation",
                table: "OnlineBookingModels");

            migrationBuilder.DropColumn(
                name: "Conformation",
                table: "DirectBookingModels");
        }
    }
}
