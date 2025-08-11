using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.DTOS
{
    public class ExtraChargersDto
    {

  
        public Guid Id { get; set; }
       
        public string ExtraChargeType { get; set; }
        public double Amount { get; set; }

        public double RateUSD { get; set; }
        public double RateLKR { get; set; }
        public string Comment { get; set; }
        public string Details { get; set; }

    }
}
