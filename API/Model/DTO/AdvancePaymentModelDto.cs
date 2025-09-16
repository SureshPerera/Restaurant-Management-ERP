using API.Model.Reservation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model.DTO
{
    public class AdvancePaymentModelDto
    {
        
        public Guid Id { get; set; }
        
        public double PayingAmount { get; set; }
     
        public string? PaymentType { get; set; }

        public string? OderType { get; set; }

        public DateTime OderDate { get; set; }
        public string? Details { get; set; }
        public Guid DirectBookingId { get; set; }
       
        public DirectBookingModel? DirectBooking { get; set; }
    }
}
