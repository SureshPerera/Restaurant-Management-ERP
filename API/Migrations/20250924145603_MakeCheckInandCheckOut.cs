using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MakeCheckInandCheckOut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CheckIn",
                table: "OnlineBookingModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CheckOut",
                table: "OnlineBookingModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CheckIn",
                table: "DirectBookingModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CheckOut",
                table: "DirectBookingModels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "OnlineBookingModels");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "OnlineBookingModels");

            migrationBuilder.DropColumn(
                name: "CheckIn",
                table: "DirectBookingModels");

            migrationBuilder.DropColumn(
                name: "CheckOut",
                table: "DirectBookingModels");
        }
    }
}
