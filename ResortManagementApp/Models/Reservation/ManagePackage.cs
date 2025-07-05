
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResortManagementApp.Models.Reservation
{
    
    public class ManagePackage
    {
        
        [Required(ErrorMessage ="Please Enter Package Name! Package Name should be Unique")]
        [MaxLength(100)]
        public string PackageName { get; set; }
        [Required (ErrorMessage ="Please Enter Package Details!")]
        public string PackageDetails { get; set; }

        
        
        [Required (ErrorMessage ="Please Enter Accomadation Type!")]
        public string AccomadationType { get; set; }

        [Required(ErrorMessage = "Please Select Basis!")]
        
        public string? EnatitleMeal1 { get; set; }
        public string? EnatitleMeal2 { get; set; }
        public string? EnatitleMeal3 { get; set; }
        public string? EveSmack { get; set; }

        
    }

    public class SpacialPacks
    {
        
        [Required (ErrorMessage ="Please Enter Name Of Spacial Packages!")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required (ErrorMessage ="Please Enter Discriptions!")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please Enter Cost!")]
        public double Cost { get; set; }
        [Required(ErrorMessage ="Please Enter Price!")]
        public double Price { get; set; }

        public string? Remark { get; set; }
        public ICollection<ManagePackage> Packages { get; set; } = new List<ManagePackage>();
    }

    public class RoomRate
    {
        
        [Required (ErrorMessage ="Please Enter Discription for Room Rate!")]
        public string Discriptions { get; set; }
        [Required (ErrorMessage ="Please Enter Rate for Room!")]
        public double Rate { get; set; }
        public ICollection<ManagePackage> Packages { get; set; } = new List<ManagePackage>();
    }

    public class Basis
    {
        
        [Required(ErrorMessage ="Please Enter Basis Type!")]
        [MaxLength(100)]
        public string BasisType { get; set; }
        public ICollection<ManagePackage> Packages { get; set; } = new List<ManagePackage>();
    }
}
