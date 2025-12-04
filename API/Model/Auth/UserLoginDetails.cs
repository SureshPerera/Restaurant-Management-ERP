using System.ComponentModel.DataAnnotations;

namespace API.Model.Auth
{
    public class UserLoginDetails
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsLoging { get; set; } = false;
        public DateTime? LogingTime { get; set; } = DateTime.Now;
        public string? IpAddress { get; set; }
        public string? UserName { get; set; }
    }
}
