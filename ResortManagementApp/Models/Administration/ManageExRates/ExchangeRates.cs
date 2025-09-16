using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.ManageExRates
{
    public class ExchangeRates
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? CurrencyName { get; set; }
        [Required]
        public double  SellingRate{ get; set; }
        [Required]
        public double BuyingRate { get; set; }

    }
}
