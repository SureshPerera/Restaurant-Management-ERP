using API.Model.ClientManagemnet;
using API.Model.Reservation;
using API.Model.Reservation.OnlineBooking;
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
     
    }
}
