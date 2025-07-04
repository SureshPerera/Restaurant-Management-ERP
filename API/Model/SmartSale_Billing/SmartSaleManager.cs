using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPResturentManagementServerAuth.Model.SmartSale_Billing
{
    public class SmartSaleManager
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please Enter Sale Type!")]
        public Guid SaleTypeId { get; set; }

        [ForeignKey(nameof(SaleTypeId))]
        public SaleType SaleType { get; set; }

        [Required(ErrorMessage ="Please Enter Unit Price!")]
        public double UnitPrice { get; set; }
        [Required(ErrorMessage ="Please Enter Quntity!")]
        public double Quntity{ get; set; }
        public string? Remark { get; set; }
        public double? Discount { get; set; }

    }

    public class SaleType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string SaleTypes { get; set; }
        public ICollection<SmartSaleManager> Sales { get; set; } = new List<SmartSaleManager>();
    }
}
