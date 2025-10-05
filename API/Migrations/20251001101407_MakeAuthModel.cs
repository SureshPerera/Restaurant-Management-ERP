using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MakeAuthModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistationModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservations_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    CheckIn_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    Inhouse_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    HouseKeeping_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    SmartSales_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    Administration_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    UserManagement_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    ClientManagement_checkBox = table.Column<bool>(type: "bit", nullable: true),
                    DashBoard_checkBox = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistationModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistationModel");
        }
    }
}
