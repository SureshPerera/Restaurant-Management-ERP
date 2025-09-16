using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updateCheckInOut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "CheckInTime",
                table: "OnlineBookingModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "CheckOutTime",
                table: "OnlineBookingModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "CheckInTime",
                table: "DirectBookingModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "CheckOutTime",
                table: "DirectBookingModels",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckInTime",
                table: "OnlineBookingModels");

            migrationBuilder.DropColumn(
                name: "CheckOutTime",
                table: "OnlineBookingModels");

            migrationBuilder.DropColumn(
                name: "CheckInTime",
                table: "DirectBookingModels");

            migrationBuilder.DropColumn(
                name: "CheckOutTime",
                table: "DirectBookingModels");
        }
    }
}
