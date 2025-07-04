using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class DirectBooking1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectBookingModels_CustomerType_CustomerTypeId",
                table: "DirectBookingModels");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerTypeId",
                table: "DirectBookingModels",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectBookingModels_CustomerType_CustomerTypeId",
                table: "DirectBookingModels",
                column: "CustomerTypeId",
                principalTable: "CustomerType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectBookingModels_CustomerType_CustomerTypeId",
                table: "DirectBookingModels");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerTypeId",
                table: "DirectBookingModels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DirectBookingModels_CustomerType_CustomerTypeId",
                table: "DirectBookingModels",
                column: "CustomerTypeId",
                principalTable: "CustomerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
