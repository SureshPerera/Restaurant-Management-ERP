using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Reservation.DTO
{
    public class OnlineBookingDto
    {

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string? LastName { get; set; }
     
        public string PhoneNumber { get; set; }
        public DateOnly? DathOfBirth { get; set; }
   

        public string Address { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        
        public string NIC { get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }


     
        public string Nationality { get; set; }
        public string? Remark { get; set; }
        public DateOnly CheckInDate { get; set; }
        
        public DateOnly CheckOutDate { get; set; }
        public bool? Conformation { get; set; }

    }
}
