namespace API.Model.DTO
{
    public class SmartSaleModelDto
    {
        public Guid Id { get; set; }
        public string? SandryItem { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double? TotalLKR { get; set; }
        public string? Remark { get; set; }
        public double Discouunt { get; set; }
    }
}
