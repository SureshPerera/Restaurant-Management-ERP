using System.ComponentModel.DataAnnotations;

namespace API.Model.Reservation
{
    public class ManageExRates
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Please Enter currancy!")]
        public string CurrancyName { get; set; }
        [Required(ErrorMessage = "Please Enter Selling rate!")]
        public double SellingRate { get; set; }
        [Required(ErrorMessage = "Please Enter Buying rate!")]

        public double BuyingRate { get; set; }

    }
}
