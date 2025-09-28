using API.Model.Reservation;
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

        public decimal? RoomRate { get; set; }

        // ✅ Navigation
        public virtual DirectBookingModel? DirectBooking { get; set; }
        public virtual RoomModel? Room { get; set; }
    }

}
