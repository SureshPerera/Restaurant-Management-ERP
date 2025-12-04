using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API.Model.Administration
{
    public class ExtraChargeModel
    {

        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? ExtraChargeType { get; set; }
        [Precision(18, 2)]
        public decimal? Amount { get; set; }
        [Precision(18, 2)]
        public decimal? RateUSD { get; set; }
        [Precision(18, 2)]
        public decimal? RateLKR { get; set; }
        public string? Comment { get; set; }
        public string? Details { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? CreateDate { get; set; }


    }
}
