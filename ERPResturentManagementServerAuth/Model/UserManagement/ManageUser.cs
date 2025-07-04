using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPResturentManagementServerAuth.Model.UserManagement
{
    [Index(nameof(NIC),IsUnique =true)]
    public class ManageUser
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid AccessLevelId { get; set; }

        [ForeignKey(nameof(AccessLevelId))]
        public AccessLevel AccessLevel { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        public string? DateOfBirthday { get; set; }
        public string? Gender { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? Comment { get; set; }
        [Required]
        public string NIC { get; set; }
    }

    public class AccessLevel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }
        public ICollection<ManageUser> Users { get; set; } = new List<ManageUser>();
    }
}
