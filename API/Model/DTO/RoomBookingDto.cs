using API.Model.Administration;
using API.Model.Reservation;
using System.ComponentModel.DataAnnotations;

namespace API.Model.DTO
{
    public class RoomBookingDto
    {
        [Key]
        public Guid Id { get; set; }

        // Foreign Keys
        public Guid DirectBookingId { get; set; }
        public string? RoomId { get; set; }

        // Additional booking-specific properties
        public decimal RoomRate { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public string? SpecialRequests { get; set; }

        // Navigation properties
        public virtual DirectBookingModel? DirectBooking { get; set; }
        public virtual RoomModel? Room { get; set; }
    }
}
