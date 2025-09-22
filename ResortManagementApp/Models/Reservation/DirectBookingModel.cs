
using ResortManagementApp.Models.ClientManagement.AdvancePay;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResortManagementApp.Models.Reservation
{
    
    public class DirectBookingModel
    {
        [Key]
        public Guid Id{ get; set; }
        
        [StringLength(100)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }
        
        [Phone]
        public string? PhoneNumber { get; set; }
        public DateOnly? DathOfBirth { get; set; }
        

        public string? Address {  get; set; }
        [EmailAddress]
        public string? EmailAddress{ get; set; }
        
        public string? NIC{ get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }
        
        
        public string? Nationality { get; set; }
        public string? Remark { get; set; }

        public string? CustomerType { get; set; }

        public DateTime CheckInDate { get; set; }
        
        public DateTime CheckOutDate { get; set; }
        public bool Conformation { get; set; }
        public TimeOnly CheckInTime { get; set; }
        public TimeOnly CheckOutTime { get; set; }

    }

    
}
