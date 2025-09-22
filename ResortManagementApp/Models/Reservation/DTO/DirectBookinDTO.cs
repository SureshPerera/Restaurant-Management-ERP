using ResortManagementApp.Models.Reservation;
using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Reservation.DTO
{
    public class DirectBookinDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public DateOnly? DathOfBirth { get; set; }
        public string? Address { get; set; }
        public string? EmailAddress { get; set; }
        public string? NIC { get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }

        public string? Nationality { get; set; }
        public string? CustomerType { get; set; }
        public string? Remark { get; set; }
        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }
        public bool Conformation { get; set; }
        public TimeOnly CheckInTime { get; set; }
        public TimeOnly CheckOutTime { get; set; }
        public double Adult { get; set; }
        public double Kids { get; set; }

    }

}
