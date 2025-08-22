using API.Model.Administration;
using API.Model.ClientManagemnet;
using API.Model.Reservation;
using API.Model.Reservation.OnlineBooking;
using API.Model.SmartSale_Billing;

using Microsoft.EntityFrameworkCore;

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
       
     
    }
}
