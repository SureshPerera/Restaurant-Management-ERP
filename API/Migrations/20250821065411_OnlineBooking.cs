using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class OnlineBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DirectBookingModels_CustomerType_CustomerTypeId",
                table: "DirectBookingModels");

            migrationBuilder.DropTable(
                name: "OnlineBooking");

            migrationBuilder.DropTable(
                name: "CustomerType");

            migrationBuilder.DropIndex(
                name: "IX_DirectBookingModels_CustomerTypeId",
                table: "DirectBookingModels");

            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                table: "DirectBookingModels");

            migrationBuilder.CreateTable(
                name: "OnlineBookingModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DathOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditLimit = table.Column<double>(type: "float", nullable: true),
                    OpeningBalanace = table.Column<double>(type: "float", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineBookingModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnlineBookingModels");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerTypeId",
                table: "DirectBookingModels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineBooking",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditLimit = table.Column<double>(type: "float", nullable: true),
                    DathOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningBalanace = table.Column<double>(type: "float", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineBooking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineBooking_CustomerType_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "CustomerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DirectBookingModels_CustomerTypeId",
                table: "DirectBookingModels",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineBooking_CustomerTypeId",
                table: "OnlineBooking",
                column: "CustomerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DirectBookingModels_CustomerType_CustomerTypeId",
                table: "DirectBookingModels",
                column: "CustomerTypeId",
                principalTable: "CustomerType",
                principalColumn: "Id");
        }
    }
}
