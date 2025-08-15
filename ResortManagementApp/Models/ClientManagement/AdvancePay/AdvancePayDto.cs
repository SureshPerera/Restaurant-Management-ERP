using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.ClientManagement.AdvancePay
{
    public class AdvancePayDto
    {

       
        public Guid Id { get; set; }
       
        public double PayingAmount { get; set; }
       
        public double PaymentType { get; set; }

        public string OderType { get; set; }

        public DateTime OderDate { get; set; }
        public string Details { get; set; }
    }
}
