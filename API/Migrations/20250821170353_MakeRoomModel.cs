using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MakeRoomModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomFloor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumOccupancy = table.Column<int>(type: "int", nullable: false),
                    RoomStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastCleanedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastCleanedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintainStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintenanceComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomDisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomModels");
        }
    }
}
