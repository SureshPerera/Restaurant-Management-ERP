using System.ComponentModel.DataAnnotations;

namespace API.Model.DTO
{
    public class ExtraChargeModelDto
    {

      
        public Guid Id { get; set; }
        public string ExtraChargeType { get; set; }

        public double Amount { get; set; }
        public double? RateUSD { get; set; }
        public double? RateLKR { get; set; }
        public string? Comment { get; set; }
        public string? Details { get; set; }
    }
}
