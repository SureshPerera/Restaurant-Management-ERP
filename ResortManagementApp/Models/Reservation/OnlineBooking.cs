using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResortManagementApp.Models.Reservation
{
    public class OnlineBooking
    {
        
        [Required(ErrorMessage = "Please Enter First Name!")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please Enter Phone Number!")]
        [Phone]
        public string PhoneNumber { get; set; }
        public DateOnly? DathOfBirth { get; set; }
        [Required(ErrorMessage = "Please Enter Address!")]

        public string Address { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [Required(ErrorMessage = "Please Enter NIC!")]
        public string NIC { get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }
        
        
        [Required(ErrorMessage = "Please Enter Nationality!")]
        public string Nationality { get; set; }
        public string? Remark { get; set; }
    }
}
