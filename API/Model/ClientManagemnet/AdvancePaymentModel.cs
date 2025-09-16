using API.Model.Reservation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model.ClientManagemnet
{
    public class AdvancePaymentModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double PayingAmount { get; set; }
        [Required]
        public string? PaymentType { get; set; }

        public string? OderType { get; set; }

        public DateTime OderDate { get; set; }
        public string? Details { get; set; }
        public Guid DirectBookingId { get; set; }
        [ForeignKey(nameof(DirectBookingId))]
        public DirectBookingModel? DirectBooking { get; set; }
    }
}
