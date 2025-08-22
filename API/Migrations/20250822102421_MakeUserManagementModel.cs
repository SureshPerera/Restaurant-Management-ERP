using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MakeUserManagementModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserManagementModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DashBoard = table.Column<bool>(type: "bit", nullable: true),
                    Reservation = table.Column<bool>(type: "bit", nullable: true),
                    CheckInOut = table.Column<bool>(type: "bit", nullable: true),
                    Inhouse = table.Column<bool>(type: "bit", nullable: true),
                    HouseKeeping = table.Column<bool>(type: "bit", nullable: true),
                    SmartSalling = table.Column<bool>(type: "bit", nullable: true),
                    StockInventory = table.Column<bool>(type: "bit", nullable: true),
                    AssetsManagement = table.Column<bool>(type: "bit", nullable: true),
                    Administration = table.Column<bool>(type: "bit", nullable: true),
                    UserManagements = table.Column<bool>(type: "bit", nullable: true),
                    ClientManagement = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserManagementModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserManagementModels");
        }
    }
}
