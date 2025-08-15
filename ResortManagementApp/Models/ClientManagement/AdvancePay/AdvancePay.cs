using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.AdvancePay
{
    public class AdvancePay
    {
        [Key]
        public Guid Id{ get; set; }
        [Required]
        public double PayingAmount{ get; set; }
        [Required]
        public double PaymentType { get; set; }
        
        public string OderType { get; set; }
        
        public DateTime OderDate { get; set; }
        public string Details { get; set; }
    }
}
