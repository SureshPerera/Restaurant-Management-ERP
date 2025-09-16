using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.ManageAgents
{
    public class Agents
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? AgentName { get; set; }
        [Required]
        public string? AgentAddress { get; set; }
        
        public string? ContactPerson { get; set; }
        [Required]
        [Phone]
        public string? Mobile{ get; set; }
        public string? Fax{ get; set; }
        public string? NIC{ get; set; }
        
        [EmailAddress]
        public string? Email{ get; set; }
        public string? WebSite{ get; set; }
        public double? CreditLimit { get; set; }
        public string? VatRegNo { get; set; }
    }
}
