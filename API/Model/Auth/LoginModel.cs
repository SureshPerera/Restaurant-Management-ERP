using System.ComponentModel.DataAnnotations;

namespace API.Model.Auth
{
    public class LoginModel
    {
        [Key]
        public Guid Id;
        public Guid RegistationId { get; set; }
        public bool IsLoging { get; set; } = false;
    }
}
