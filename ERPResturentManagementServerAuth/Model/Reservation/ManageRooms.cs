﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPResturentManagementServerAuth.Model.Reservation
{
    [Index(nameof(RoomId),IsUnique =true)]
    public class ManageRooms
    {
        [Key]
        public Guid Id { get; set; }
        [Required (ErrorMessage ="Please Enter Room Id, Id should be unique!")]
        [MaxLength(10)]
        public string RoomId { get; set; }
        [Required (ErrorMessage ="Please Select Room Type!")]
        public Guid RoomTypeId { get; set; }


        [ForeignKey(nameof(RoomTypeId))]
        public RoomType RoomType { get; set; }

        [Required (ErrorMessage ="Please Enter Room Floor!")]
        [MaxLength (10)]
        public string RoomFloor { get; set; }
        [Required (ErrorMessage ="Please Enter Maximum Occupancy!")]
        public int MaximumOccupancy { get; set; }
        public bool? RoomStatus { get; set; }
        public  DateTime? LastCleanedDate { get; set; }
        public string? LastCleanedBy { get; set; }
        public string? MaintainStatus { get; set; }
        public string? MaintainComment { get; set; }
        public string? AdditionalDetails { get; set; }
        public string? RoomDisplayTital {  get; set; }


    }

    public class RoomType
    {
        [Key]
        public Guid Id { get; set; }
        [Required (ErrorMessage ="Please Enter Room Type!")]
        [MaxLength(20)]
        public string Type { get; set; }
        public ICollection<ManageRooms> Rooms { get; set; } = new List<ManageRooms>();
        public ICollection<ManagePackage> Packages { get; set; } = new List<ManagePackage>();
    }

}
