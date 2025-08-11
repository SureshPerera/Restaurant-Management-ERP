using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.SmartSales
{
    public class SmartSale
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string SandryItem { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity{ get; set; }
        public double TotalLKR{ get; set; }
        public string Remark{ get; set; }
        public string Discuount{ get; set; }
        
        
    }
}
