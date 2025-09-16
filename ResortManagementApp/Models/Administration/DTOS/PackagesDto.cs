using System.ComponentModel.DataAnnotations;

namespace ResortManagementApp.Models.Administration.DTOS
{
    public class PackagesDto
    {

        
        public Guid Id { get; set; }
       
        public string? PackageName { get; set; }
        
        public string? PackageDetails { get; set; }
       
        public string? RoomType { get; set; }
        
        public string? AccomadationType { get; set; }
        
        public string? Basis { get; set; }
        public double RoomRateSpring { get; set; }
        public double RoomRateSummer { get; set; }
        public double RoomRateAutumn { get; set; }
        public double RoomRateWinter { get; set; }
        public string? Entitlemeal1 { get; set; }
        public string? Entitlemeal2 { get; set; }
        public string? Entitlemeal3 { get; set; }
        public string? Entitlemeal4 { get; set; }
        public string? SpecialPackage1 { get; set; }
        public string? SpecialPackage2 { get; set; }
        public string? SpecialPackage3 { get; set; }
        public string? SpecialPackage4 { get; set; }
    }
}
