using API.Model.Administration;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API.Model.Payment
{
    public class PaymentModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid BookingId { get; set; }
        [Precision(18, 2)]
        public decimal? Amount { get; set; }
        public string? Currency { get; set; } = "LKR";
        public string? PaymentMethod { get; set; } = "Cash";
        public string? TransactionId { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string? Status { get; set; } = "Completed";
        public string? Notes { get; set; }

        // Navigation
        public RoomBookingModel Booking { get; set; } = null!;

    }
}
