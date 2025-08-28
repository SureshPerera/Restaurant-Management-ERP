using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Pages.OnlineBookingPortal.Crud
{
    public class CustomerUsePcInfo
    {
        [Key]
        public Guid Id { get; set; }
        public string? Ip { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Browser { get; set; }
        public string? Region { get; set; }
        public string? Location { get; set; }
        public string? Organization{ get; set; }
        public string? Postal { get; set; }
        public string? timezone { get; set; }


    }
}
