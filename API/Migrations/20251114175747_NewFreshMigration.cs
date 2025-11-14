using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class NewFreshMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditLimit = table.Column<double>(type: "float", nullable: true),
                    VatRegNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DathOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditLimit = table.Column<double>(type: "float", nullable: true),
                    OpeningBalanace = table.Column<double>(type: "float", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DirectBookingModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DathOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreditLimit = table.Column<double>(type: "float", nullable: true),
                    OpeningBalanace = table.Column<double>(type: "float", nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Conformation = table.Column<bool>(type: "bit", nullable: true),
                    CheckInTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CheckOutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CheckIn = table.Column<bool>(type: "bit", nullable: true),
                    CheckOut = table.Column<bool>(type: "bit", nullable: true),
                    Adult = table.Column<int>(type: "int", nullable: false),
                    Kids = table.Column<int>(type: "int", nullable: false),
                    Cancellations = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectBookingModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExRateModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SellingRate = table.Column<double>(type: "float", nullable: false),
                    BuyingRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExRateModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExtraChargeModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExtraChargeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    RateUSD = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    RateLKR = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraChargeModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnlineBookingModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DathOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditLimit = table.Column<double>(type: "float", nullable: true),
                    OpeningBalanace = table.Column<double>(type: "float", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoOfRooms = table.Column<int>(type: "int", nullable: true),
                    NoOfAdults = table.Column<int>(type: "int", nullable: true),
                    NoOfChildren = table.Column<int>(type: "int", nullable: true),
                    PramoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conformation = table.Column<bool>(type: "bit", nullable: false),
                    CheckOutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CheckInTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    CheckIn = table.Column<bool>(type: "bit", nullable: true),
                    CheckOut = table.Column<bool>(type: "bit", nullable: true),
                    Cancellations = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineBookingModels", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "RoomModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumOccupancy = table.Column<int>(type: "int", nullable: false),
                    RoomStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastCleanedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastCleanedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintainStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintenanceComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomDisplayTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAvalable = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SmartSaleModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SandryItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalLKR = table.Column<double>(type: "float", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discouunt = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SmartSaleModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLoging = table.Column<bool>(type: "bit", nullable: false),
                    LogingTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserManagementModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NIC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "AdvancePaymentModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayingAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OderType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceptNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancePaymentModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancePaymentModels_DirectBookingModels_DirectBookingId",
                        column: x => x.DirectBookingId,
                        principalTable: "DirectBookingModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomBookingsModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomRate = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBookingsModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomBookingsModel_DirectBookingModels_DirectBookingId",
                        column: x => x.DirectBookingId,
                        principalTable: "DirectBookingModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBookingsModel_RoomModels_RoomId",
                        column: x => x.RoomId,
                        principalTable: "RoomModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentModel_RoomBookingsModel_BookingId",
                        column: x => x.BookingId,
                        principalTable: "RoomBookingsModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancePaymentModels_DirectBookingId",
                table: "AdvancePaymentModels",
                column: "DirectBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectBookingModels_NIC",
                table: "DirectBookingModels",
                column: "NIC",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentModel_BookingId",
                table: "PaymentModel",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookingsModel_DirectBookingId",
                table: "RoomBookingsModel",
                column: "DirectBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBookingsModel_RoomId",
                table: "RoomBookingsModel",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancePaymentModels");

            migrationBuilder.DropTable(
                name: "AgentModels");

            migrationBuilder.DropTable(
                name: "ClientModels");

            migrationBuilder.DropTable(
                name: "ExRateModel");

            migrationBuilder.DropTable(
                name: "ExtraChargeModels");

            migrationBuilder.DropTable(
                name: "OnlineBookingModels");

            migrationBuilder.DropTable(
                name: "PackageModels");

            migrationBuilder.DropTable(
                name: "PaymentModel");

            migrationBuilder.DropTable(
                name: "RegistationModel");

            migrationBuilder.DropTable(
                name: "SmartSaleModels");

            migrationBuilder.DropTable(
                name: "UserLoginDetails");

            migrationBuilder.DropTable(
                name: "UserManagementModels");

            migrationBuilder.DropTable(
                name: "RoomBookingsModel");

            migrationBuilder.DropTable(
                name: "DirectBookingModels");

            migrationBuilder.DropTable(
                name: "RoomModels");
        }
    }
}
