using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class MakePackageModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PackageModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccomadationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Basis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomRateSpring = table.Column<double>(type: "float", nullable: true),
                    RoomRateSummer = table.Column<double>(type: "float", nullable: true),
                    RoomRateAutumn = table.Column<double>(type: "float", nullable: true),
                    RoomRateWinter = table.Column<double>(type: "float", nullable: true),
                    Entitlemeal1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entitlemeal2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entitlemeal3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Entitlemeal4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialPackage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialPackage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialPackage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecialPackage4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageModels");
        }
    }
}
