using System.ComponentModel.DataAnnotations;

namespace ERPResturentManagementServerAuth.Model.ClientManagemnet
{
    public class AdvancePayoment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double PayingAmount {  get; set; }
        [Required]
        public PayomentType PayomentType { get; set; }
    }

    public class PayomentType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    }
}
