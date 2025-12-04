using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllFunctionsDateTimeUDT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "UserManagementModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SmartSaleModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "RoomModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "RoomBookingsModel",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "RegistationModel",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "PaymentModel",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "PackageModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "OnlineBookingModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ExtraChargeModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ExRateModel",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "DirectBookingModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "ClientModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AgentModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "AdvancePaymentModels",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "UserManagementModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SmartSaleModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "RoomModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "RoomBookingsModel");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "RegistationModel");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "PaymentModel");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "PackageModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "OnlineBookingModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ExtraChargeModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ExRateModel");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "DirectBookingModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "ClientModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AgentModels");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "AdvancePaymentModels");
        }
    }
}
