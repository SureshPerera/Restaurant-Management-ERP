using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.ManageRooms
{
    public class Rooms
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string RoomId { get; set; }
        [Required]
        public string RoomType { get; set; }
        [Required]
        public string RoomFloor { get; set; }
        [Required]
        public int MaximumOccupancy{ get; set; }
        
        public string? RoomStatus { get; set; }
        
        public DateTime LastCleanedDate { get; set; }

        public DateTime LastCleanedBy { get; set; }

        public string? MaintainStatus { get; set; }

        public string? MaintenanceComment { get; set; }
        public string? AdditionalDetails { get; set; }
        public string? RoomDisplayTitle { get; set; }
    }
}
