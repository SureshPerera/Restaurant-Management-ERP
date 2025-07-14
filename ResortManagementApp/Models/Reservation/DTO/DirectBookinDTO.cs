using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Reservation.DTO
{
    public class DirectBookinDTO
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DathOfBirth { get; set; }
        public string Address { get; set; }
        public string? EmailAddress { get; set; }
        public string NIC { get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }

        public string Nationality { get; set; }
        public string? Remark { get; set; }
        public Guid CustomerTypeId { get; set; }
    }
    public class CustomerType
    {

        public string Type { get; set; }
        public ICollection<DirectBookingModel> DirectBookings { get; set; }
        public ICollection<OnlineBooking> OnlineBookings { get; set; }
    }
}
