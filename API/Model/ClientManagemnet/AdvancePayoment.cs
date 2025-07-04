using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPResturentManagementServerAuth.Model.ClientManagemnet
{
    public class AdvancePayoment
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double PayingAmount {  get; set; }
        [Required]
        public Guid PaymentTypeId { get; set; }

        [ForeignKey(nameof(PaymentTypeId))]
        public PayomentType PayomentType { get; set; }
        [Required]
        public string OrderType {  get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string OrderDetails { get; set; }

    }

    public class PayomentType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }
        public ICollection<AdvancePayoment> AdvancePayments { get; set; } = new List<AdvancePayoment>();
    }
}
