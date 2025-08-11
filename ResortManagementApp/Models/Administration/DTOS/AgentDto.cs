using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.DTOS
{
    public class AgentDto
    {
       
        public Guid Id { get; set; }
        
        public string AgentName { get; set; }
        
        public string AgentAddress { get; set; }

        public string? ContactPerson { get; set; }
       
        public string Mobile { get; set; }
        public string Fax { get; set; }

        
        public string Email { get; set; }
        public string WebSite { get; set; }
        public double CreditLimit { get; set; }
        public string VatRegNo { get; set; }
    }
}
