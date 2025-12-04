
using API.Model.Administration;
using API.Model.Reservation.OnlineBooking;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model.Reservation
{
    [Index(nameof(NIC),IsUnique = true)]
    public class DirectBookingModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please Enter First Name!")]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [StringLength(100)]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number!")]
        [Phone]
        public string? PhoneNumber { get; set; }

        public DateOnly? DathOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Address!")]
        public string? Address { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Please Enter NIC!")]
        public string? NIC { get; set; }

        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }

        public string? CustomerType { get; set; }
        public string? Remark { get; set; }

        [Required(ErrorMessage = "Please Enter Check In Date!")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Please Enter Check Out Date!")]
        public DateTime CheckOutDate { get; set; }

        public bool? Conformation { get; set; } = false;
        public TimeOnly CheckInTime { get; set; }
        public TimeOnly CheckOutTime { get; set; }
        public bool? CheckIn { get; set; } = false;
        public bool? CheckOut { get; set; } = false;
        public int Adult { get; set; }
        public int Kids { get; set; }
        public bool? Cancellations { get; set; } = false;

        // ✅ Navigation
        public virtual ICollection<RoomBookingModel> RoomBookings { get; set; } = new List<RoomBookingModel>();
        public DateTime? CreateDate { get; set; }
    }



}
