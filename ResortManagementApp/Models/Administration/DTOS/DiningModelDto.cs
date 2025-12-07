namespace ResortManagementApp.Models.Administration.DTOS
{
    public class DiningModelDto
    {
        public Guid Id { get; set; }
        public string? Tital { get; set; }
        public string? Discriptions { get; set; }
        public double Price { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
