using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.SmartSales.Dtos
{
    public class SmartSaleDto
    {
        
        public Guid Id { get; set; }
      
        public string SandryItem { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalLKR { get; set; }
        public string Remark { get; set; }
        public double Discuount { get; set; }
    }
}
