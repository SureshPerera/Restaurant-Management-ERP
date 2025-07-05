using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Reservation
{
    public class ManageExtra
    {
        
        [Required(ErrorMessage ="Please Enter Extra Change Type!")]
        public string ExtraChangeType { get; set; }
        [Required(ErrorMessage = "Please Enter Rate USD!")]
        public double RateUSD { get; set; }
        [Required(ErrorMessage = "Please Enter Rate LKR!")]
        public double RateLKR { get; set; }
        public double? Comment { get; set; }
        public string? Details { get; set; }
    }
}
