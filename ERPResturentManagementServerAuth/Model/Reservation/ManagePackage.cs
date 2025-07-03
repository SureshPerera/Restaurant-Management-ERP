using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ERPResturentManagementServerAuth.Model.Reservation
{
    [Index(nameof(PackageName),IsUnique =true)]
    public class ManagePackage
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Please Enter Package Name! Package Name should be Unique")]
        [MaxLength(100)]
        public string PackageName { get; set; }
        [Required (ErrorMessage ="Please Enter Package Details!")]
        public string PackageDetails { get; set; }
        [Required (ErrorMessage ="Please Select Room Type!")]
        public RoomType RoomType { get; set; }
        [Required (ErrorMessage ="Please Enter Accomadation Type!")]
        public string AccomadationType { get; set; }
        [Required (ErrorMessage ="Please Select Basis!")]
        public Basis Basis { get; set; }
        [Required(ErrorMessage ="Please Select Room Rate!")]
        public RoomRate RoomRate { get; set; }
        public string? EnatitleMeal1 { get; set; }
        public string? EnatitleMeal2 { get; set; }
        public string? EnatitleMeal3 { get; set; }
        public string? EveSmack { get; set; }
        public SpacialPacks? SpacialPacks { get; set; }
    }

    public class SpacialPacks
    {
        [Key]
        public Guid Id { get; set; }
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
    }

    public class RoomRate
    {
        [Key]
        public Guid Id { get; set; }
        [Required (ErrorMessage ="Please Enter Discription for Room Rate!")]
        public string Discriptions { get; set; }
        [Required (ErrorMessage ="Please Enter Rate for Room!")]
        public double Rate { get; set; }
    }

    public class Basis
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Please Enter Basis Type!")]
        [MaxLength(100)]
        public string BasisType { get; set; }
    }
}
