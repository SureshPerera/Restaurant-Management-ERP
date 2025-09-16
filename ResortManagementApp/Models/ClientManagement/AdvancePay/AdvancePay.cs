using ResortManagementApp.Pages.Reservations.DirectBookigModelCRUD;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResortManagementApp.Models.ClientManagement.AdvancePay
{
    public class AdvancePay
    {
        [Key]
        public Guid Id{ get; set; }
        [Required]
        public double PayingAmount{ get; set; }
        [Required]
        public string? PaymentType { get; set; }
        
        public string? OderType { get; set; }
        
        public DateTime OderDate { get; set; }
        public string? Details { get; set; }
        public Guid DirectBookingId { get; set; }
        [ForeignKey(nameof(DirectBookingId))]
        public DirectBooking? DirectBooking { get; set; }
    }
}
