using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.DTOS
{
    public class RoomsDto
    {
     
        public Guid Id { get; set; }
        public string RoomId { get; set; }
        
        public string RoomType { get; set; }

        public string RoomFloor { get; set; }
 
        public int MaximumOccupancy { get; set; }

        public string? RoomStatus { get; set; }

        public DateTime LastCleanedDate { get; set; }

        public string? LastCleanedBy { get; set; }

        public string? MaintainStatus { get; set; }

        public string? MaintenanceComment { get; set; }
        public string? AdditionalDetails { get; set; }
        public string? RoomDisplayTitle { get; set; }
    }
}
