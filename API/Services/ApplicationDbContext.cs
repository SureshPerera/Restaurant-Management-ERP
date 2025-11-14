using API.Model.Administration;
using API.Model.Auth;
using API.Model.ClientManagemnet;
using API.Model.Payment;
using API.Model.Reservation;
using API.Model.Reservation.OnlineBooking;
using API.Model.SmartSale_Billing;
using API.Model.UserManagement;
using Microsoft.EntityFrameworkCore;
using ResortManagementApp.Models.Auth;

namespace API.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<DirectBookingModel> DirectBookingModels { get; set; }
        public DbSet<OnlineBookingModel> OnlineBookingModels { get; set; }
        public DbSet<AdvancePaymentModel> AdvancePaymentModels { get; set; }
        public DbSet<AgentModel> AgentModels { get; set; }
        public DbSet<ExRateModel> ExRateModel { get; set; }
        public DbSet<ExtraChargeModel> ExtraChargeModels { get; set; }
        public DbSet<PackageModel> PackageModels { get; set; }
        public DbSet<RoomModel> RoomModels { get; set; }
        public DbSet<SmartSaleModel> SmartSaleModels { get; set; }
        public DbSet<UserManagementModel> UserManagementModels { get; set; }
        public DbSet<ClientModel> ClientModels { get; set; }
        public DbSet<RoomBookingModel> RoomBookingsModel { get; set; }
        public DbSet<PaymentModel> PaymentModel { get; set; }
        public DbSet<UserLoginDetails> UserLoginDetails { get; set; }
        public DbSet<RegistationModel> RegistationModel{ get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentModel>()
                .HasOne(p => p.Booking)
                .WithMany(b => b.Payments)
                .HasForeignKey(p => p.BookingId)
            .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
