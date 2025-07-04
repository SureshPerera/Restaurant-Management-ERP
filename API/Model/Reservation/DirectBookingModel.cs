
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model.Reservation
{
    [Index(nameof(NIC),IsUnique = true)]
    public class DirectBookingModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Please Enter First Name!")]
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Please Enter Phone Number!")]
        [Phone]
        public string PhoneNumber { get; set; }
        public DateTime? DathOfBirth { get; set; }
        [Required(ErrorMessage = "Please Enter Address!")]

        public string Address {  get; set; }
        [EmailAddress]
        public string? EmailAddress{ get; set; }
        [Required (ErrorMessage= "Please Enter NIC!")]
        public string NIC{ get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }
        
        public Guid? CustomerTypeId { get; set; }

        [ForeignKey(nameof(CustomerTypeId))]
        public CustomerType? CustomerType { get; set; }
        [Required (ErrorMessage ="Please Enter Nationality!")]
        public string Nationality { get; set; }
        public string? Remark { get; set; }


    }

    public class CustomerType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }
        public ICollection<DirectBookingModel> DirectBookings { get; set; }
        public ICollection<OnlineBooking> OnlineBookings { get; set; }
    }
}
