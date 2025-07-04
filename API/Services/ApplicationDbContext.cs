using API.Model.Reservation;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<DirectBookingModel> DirectBookingModels { get; set; }
     
    }
}
