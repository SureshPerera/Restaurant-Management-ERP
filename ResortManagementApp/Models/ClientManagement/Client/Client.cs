using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.Client
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        public string? LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string NIC { get; set; }
        
        [EmailAddress]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remark { get; set; }
        public string? Comment { get; set; }
        public string? Country { get; set; }


    }
}
