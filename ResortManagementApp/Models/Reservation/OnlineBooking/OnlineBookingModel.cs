using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Reservation.OnlineBookingModel
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
        public DateTime? CheckInDate { get; set; }
        
        public DateTime? CheckOutDate { get; set; }
        public int? NoOfRooms { get; set; }
        public int? NoOfAdults { get; set; } 
        public int? NoOfChildren { get; set; } 
        public string? PramoCode { get; set; }
        public bool Conformation { get; set; }
        public TimeOnly CheckInTime { get; set; }
        public TimeOnly CheckOutTime { get; set; }
        public bool CheckIn { get; set; }
        public bool CheckOut { get; set; }
    }
}
