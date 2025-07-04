using System.ComponentModel.DataAnnotations;

namespace API.Model.Reservation
{
    public class ManageAgent
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Please Enter Agent Name!")]
        public string  AgentName { get; set; }
        [Required(ErrorMessage = "Please Enter Address!")]
        public string Address { get; set; }

        public string? ContactPerson { get; set; }
        [Required]
        [Phone]
        public string Phone{ get; set; }
        public string? Fax { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? Website { get; set; }
        public double? CreditLimit { get; set; }
        public string? VATRegNo { get; set; }
    }
}
