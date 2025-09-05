using System.ComponentModel.DataAnnotations;

namespace API.Model.Reservation.OnlineBooking
{
    public class OnlineBookingModel
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(100)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }

        [Phone]
        public string? PhoneNumber { get; set; }
        public DateOnly? DathOfBirth { get; set; }


        public string? Address { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public string? NIC { get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }


        public string? Nationality { get; set; }
        public string? Remark { get; set; }

        public string? CustomerType { get; set; }

        [Required(ErrorMessage = "Please Enter Check In Date!")]
        public DateTime CheckInDate { get; set; }
        [Required(ErrorMessage = "Please Enter Check Out Date!")]
        public DateTime CheckOutDate { get; set; }
        public int? NoOfRooms { get; set; } = 0;
        public int? NoOfAdults { get; set; } = 0;
        public int? NoOfChildren { get; set; } = 0;
        public string? PramoCode { get; set; }
        public bool? Conformation { get; set; }
    }
}
