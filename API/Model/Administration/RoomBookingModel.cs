using API.Model.Payment;
using API.Model.Reservation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API.Model.Administration
{
    public class RoomBookingModel
    {
        [Key]
        public Guid Id { get; set; }

        // ✅ Foreign Keys
        public Guid DirectBookingId { get; set; }
        public Guid RoomId { get; set; }
        [Precision(18, 2)]
        public decimal? RoomRate { get; set; }

        // ✅ Navigation
        public virtual DirectBookingModel? DirectBooking { get; set; }
        public virtual RoomModel? Room { get; set; }
        public DateTime? CreateDate { get; set; }

        public ICollection<PaymentModel> Payments { get; set; } = new List<PaymentModel>();
    }
}


