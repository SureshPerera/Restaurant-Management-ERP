using System.ComponentModel.DataAnnotations;

namespace API.Model.Administration
{
    public class RoomModel
    {
        [Key]
        public Guid Id { get; set; }

        public string? RoomId { get; set; }

        [Required]
        public string? RoomType { get; set; }

        [Required]
        public string? RoomFloor { get; set; }

        [Required]
        public int MaximumOccupancy { get; set; }

        public string? RoomStatus { get; set; }
        public DateTime? LastCleanedDate { get; set; }
        public string? LastCleanedBy { get; set; }
        public string? MaintainStatus { get; set; }
        public string? MaintenanceComment { get; set; }
        public string? AdditionalDetails { get; set; }
        public string? RoomDisplayTitle { get; set; }
        public bool? IsAvalable { get; set; }

        // ✅ Navigation
        public virtual ICollection<RoomBookingModel> RoomBookings { get; set; } = new List<RoomBookingModel>();
    }

}
