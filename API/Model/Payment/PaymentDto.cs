using API.Model.Administration;

namespace API.Model.Payment
{
    public class PaymentDto
    {
        public Guid Id { get; set; } 
        public Guid BookingId { get; set; }

        public decimal Amount { get; set; }
        public string Currency { get; set; } = "LKR";
        public string PaymentMethod { get; set; } = "Cash";
        public string? TransactionId { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
        public string? Status { get; set; } = "Completed";
        public string? Notes { get; set; }


    }
}
