using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.DTOS
{
    public class ExtraChargersDto
    {

  
        public Guid Id { get; set; }
       
        public string ExtraChargeType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? RateUSD { get; set; }
        public decimal? RateLKR { get; set; }
        public string?  Comment { get; set; }
        public string? Details { get; set; }
        public DateTime? DateTime { get; set; }

    }
}
