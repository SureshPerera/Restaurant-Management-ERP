using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.Client
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string NIC { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remark { get; set; }
        public string? Comment { get; set; }
        public string? Country { get; set; }

    }
}
