using System.ComponentModel.DataAnnotations;

namespace API.Model.DTO
{
    public class OnlineBookingModelDto
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
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
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int? NoOfRooms { get; set; } = 0;
        public int? NoOfAdults { get; set; } = 0;
        public int? NoOfChildren { get; set; } = 0;
        public string? PramoCode { get; set; }
        public bool Conformation { get; set; }
        public TimeOnly CheckInTime { get; set; }
        public TimeOnly CheckOutTime { get; set; }
        public bool? CheckIn { get; set; }
        public bool? CheckOut { get; set; }
    }
}
