using System.ComponentModel.DataAnnotations;

namespace API.Model.DTO
{
    public class ExrateModelDto
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string CurrencyName { get; set; }
        [Required]
        public double SellingRate { get; set; }
        [Required]
        public double BuyingRate { get; set; }
    }
}
