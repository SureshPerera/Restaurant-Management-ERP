using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.Message
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Type{ get; set; }
        [Required]
        public string? Messages{ get; set; }

    }
}
