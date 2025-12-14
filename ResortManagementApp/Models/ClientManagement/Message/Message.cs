using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.Message
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = "SMS";
        public string? Messages { get; set; }
        public string? ReceiverPhone { get; set; }
        public string? ReceiverEmail { get; set; }

    }
}
