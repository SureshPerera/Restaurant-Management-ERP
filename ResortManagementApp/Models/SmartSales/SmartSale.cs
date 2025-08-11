using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.SmartSales
{
    public class SmartSale
    {
        [Key]
        public Guid Id { get; set; }
        
        public string SandryItem { get; set; }
        public string UnitPrice { get; set; }
        
        
    }
}
