namespace ResortManagementApp.Models.Auth.AuthDto
{
    public class RegistationDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? AccessLevel { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Comments { get; set; }
       
        public bool? Reservations_checkBox { get; set; }
        public bool? CheckIn_checkBox { get; set; }
        public bool? Inhouse_checkBox { get; set; }
        public bool? HouseKeeping_checkBox { get; set; }
        public bool? SmartSales_checkBox { get; set; }
        public bool? Administration_checkBox { get; set; }
        public bool? UserManagement_checkBox { get; set; }
        public bool? ClientManagement_checkBox { get; set; }
        public bool? DashBoard_checkBox { get; set; }

    }
}
