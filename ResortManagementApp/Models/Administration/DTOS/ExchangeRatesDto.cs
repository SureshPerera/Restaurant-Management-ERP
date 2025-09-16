using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.DTOS
{
    public class ExchangeRatesDto
    {
     
        public Guid Id { get; set; }

        public string? CurrencyName { get; set; }
      
        public double SellingRate { get; set; }
        
        public double BuyingRate { get; set; }
    }
}
