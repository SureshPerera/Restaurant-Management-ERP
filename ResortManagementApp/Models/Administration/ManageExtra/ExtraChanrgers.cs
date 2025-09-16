using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.ManageExtra
{
    public class ExtraChanrgers
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? ExtraChargeType { get; set; }

        public decimal? Amount { get; set; }
        public decimal? RateUSD { get; set; }
        public decimal? RateLKR { get; set; }
        public string? Comment { get; set; }
        public string? Details{ get; set; }

    }
}
