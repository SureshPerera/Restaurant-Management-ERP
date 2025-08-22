using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace API.Model.DTO
{
    public class UserManagementModelDto
    {
       
        public Guid Id { get; set; }
        
        public string NIC { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        [PasswordPropertyText]
        public string PassWord { get; set; }
        [Phone]
        public string PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

        public string AccessLevel { get; set; }
        public DateOnly DOB { get; set; }
        public string Gender { get; set; }
        public string? Address { get; set; }
        public string? Comment { get; set; }

        public bool? DashBoard { get; set; }
        public bool? Reservation { get; set; }
        public bool? CheckInOut { get; set; }
        public bool? Inhouse { get; set; }
        public bool? HouseKeeping { get; set; }
        public bool? SmartSalling { get; set; }
        public bool? StockInventory { get; set; }
        public bool? AssetsManagement { get; set; }
        public bool? Administration { get; set; }
        public bool? UserManagements { get; set; }
        public bool? ClientManagement { get; set; }
    }
}
