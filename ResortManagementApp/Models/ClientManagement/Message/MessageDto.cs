using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.Message
{
    public class MessageDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Messages { get; set; }
    }
}
