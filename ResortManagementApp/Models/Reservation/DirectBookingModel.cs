﻿
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResortManagementApp.Models.Reservation
{
    
    public class DirectBookingModel
    {
        [Key]
        public Guid Id{ get; set; }
        
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }
        
        [Phone]
        public string PhoneNumber { get; set; }
        public DateTime? DathOfBirth { get; set; }
        

        public string Address {  get; set; }
        [EmailAddress]
        public string? EmailAddress{ get; set; }
        
        public string NIC{ get; set; }
        public double? CreditLimit { get; set; }
        public double? OpeningBalanace { get; set; }
        
        
        public string Nationality { get; set; }
        public string? Remark { get; set; }

        public string CustomerType { get; set; }


    }

    public enum CustomerType
    {
        [Display(Name = "Local Customer")]
        Local,
        [Display(Name = "Foreign Customer")]

        Foreign,
        [Display(Name = "VIP Customer")]

        VIP

    }
}
