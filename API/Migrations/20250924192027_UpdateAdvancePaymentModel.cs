using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdvancePaymentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccNo",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheckNo",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentTime",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceptNo",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoucherNo",
                table: "AdvancePaymentModels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccNo",
                table: "AdvancePaymentModels");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "AdvancePaymentModels");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "AdvancePaymentModels");

            migrationBuilder.DropColumn(
                name: "CheckNo",
                table: "AdvancePaymentModels");

            migrationBuilder.DropColumn(
                name: "PaymentTime",
                table: "AdvancePaymentModels");

            migrationBuilder.DropColumn(
                name: "ReceptNo",
                table: "AdvancePaymentModels");

            migrationBuilder.DropColumn(
                name: "VoucherNo",
                table: "AdvancePaymentModels");
        }
    }
}
