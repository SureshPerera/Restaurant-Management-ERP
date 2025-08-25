using System.ComponentModel.DataAnnotations;

namespace API.Model.DTO
{
    public class AgentModelDto
    {
      
        public Guid Id { get; set; }
       
        public string AgentName { get; set; }
       
        public string AgentAddress { get; set; }

        public string? ContactPerson { get; set; }
      
        [Phone]
        public string Mobile { get; set; }
        public string Fax { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string NIC { get; set; }
        public string WebSite { get; set; }
        public double CreditLimit { get; set; }
        public string VatRegNo { get; set; }
    }
}
