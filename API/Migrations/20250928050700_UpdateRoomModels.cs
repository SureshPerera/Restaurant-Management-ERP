using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRoomModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomBooking_RoomModels_RoomId1",
                table: "RoomBooking");

            migrationBuilder.DropIndex(
                name: "IX_RoomBooking_RoomId1",
                table: "RoomBooking");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                table: "RoomBooking");

            migrationBuilder.DropColumn(
                name: "RoomId1",
                table: "RoomBooking");

            migrationBuilder.DropColumn(
                name: "SpecialRequests",
                table: "RoomBooking");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "RoomBooking",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomBooking_RoomId",
                table: "RoomBooking",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomBooking_RoomModels_RoomId",
                table: "RoomBooking",
                column: "RoomId",
                principalTable: "RoomModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomBooking_RoomModels_RoomId",
                table: "RoomBooking");

            migrationBuilder.DropIndex(
                name: "IX_RoomBooking_RoomId",
                table: "RoomBooking");

            migrationBuilder.AlterColumn<string>(
                name: "RoomId",
                table: "RoomBooking",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                table: "RoomBooking",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RoomId1",
                table: "RoomBooking",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecialRequests",
                table: "RoomBooking",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomBooking_RoomId1",
                table: "RoomBooking",
                column: "RoomId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomBooking_RoomModels_RoomId1",
                table: "RoomBooking",
                column: "RoomId1",
                principalTable: "RoomModels",
                principalColumn: "Id");
        }
    }
}
