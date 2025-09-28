namespace ResortManagementApp.Models.Administration.DTOS
{
    public class AssignRoomDto
    {
        public Guid DirectBookingId { get; set; }
        public Guid RoomId { get; set; }
        public decimal RoomRate { get; set; }
    }
}
