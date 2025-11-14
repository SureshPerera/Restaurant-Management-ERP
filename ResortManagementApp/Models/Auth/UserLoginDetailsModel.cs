using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Auth
{
    public class UserLoginDetailsModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? NIC { get; set; }
        public bool IsLoging { get; set; } = false;
        public DateTime LogingTime { get; set; } = DateTime.Now;
        public string IpAddress { get; set; }
    }
}
