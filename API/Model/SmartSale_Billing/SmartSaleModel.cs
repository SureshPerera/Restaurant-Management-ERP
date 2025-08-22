using System.ComponentModel.DataAnnotations;

namespace API.Model.SmartSale_Billing
{
    public class SmartSaleModel
    {
        [Key]
        public Guid Id { get; set; }
        public string SandryItem { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double? TotalLKR { get; set; }
        public string? Remark { get; set; }
        public double? Discouunt { get; set; }
    }
}
