using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Reservation
{
    public class ManageExRates
    {
        
        [Required(ErrorMessage ="Please Enter currancy!")]
        public string CurrancyName { get; set; }
        [Required(ErrorMessage = "Please Enter Selling rate!")]
        public double SellingRate { get; set; }
        [Required(ErrorMessage = "Please Enter Buying rate!")]

        public double BuyingRate { get; set; }

    }
}
