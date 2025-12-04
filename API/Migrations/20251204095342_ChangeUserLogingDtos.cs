using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ChangeUserLogingDtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NIC",
                table: "UserLoginDetails");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserLoginDetails",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "UserLoginDetails",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "NIC",
                table: "UserLoginDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
