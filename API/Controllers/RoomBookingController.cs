﻿using API.Model.Administration;
using API.Services;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResortManagementApp.Models.Administration.ManageRooms;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomBookingController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public RoomBookingController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("Available/{directBookingId:guid}")]
        public async Task<IActionResult> GetAllAvalableRoom(Guid directBookingId)
        {
            var DomainModel = await dbContext.DirectBookingModels.FindAsync(directBookingId);
            if (DomainModel == null)
            {
                return NotFound($"Direct booking with Id {directBookingId} not found.");
            }
            var checkIn = DomainModel.CheckInDate;
            var checkOut = DomainModel.CheckOutDate;


            var availableRooms = await dbContext.RoomModels
            .Where(r => !r.RoomBookings.Any(rb =>
              rb.DirectBooking != null &&
              (checkIn < rb.DirectBooking.CheckOutDate &&
               checkOut > rb.DirectBooking.CheckInDate)))
            .ToListAsync();

            
            return Ok(availableRooms);
        }
        [HttpPut("Assign")]
        public async Task<IActionResult> AssingRoom([FromBody] AssignRoomDto assignRoomDto)
        {
            var booking = await dbContext.DirectBookingModels.FirstOrDefaultAsync(b => b.Id == assignRoomDto.DirectBookingId);
            var room = await dbContext.RoomModels.FirstOrDefaultAsync(r => r.Id == assignRoomDto.RoomId);

            if (booking == null)
            {
                return NotFound("Booking not found.");
            }
            if (room == null)
            {
                return NotFound("Room not found.");

            }
            var isBooked = await dbContext.RoomBookingsModel
                    .AnyAsync(rb => rb.RoomId == assignRoomDto.RoomId &&
                    rb.DirectBooking.CheckInDate < booking.CheckOutDate &&
                    rb.DirectBooking.CheckOutDate > booking.CheckInDate);

            if (isBooked)
            {
                return BadRequest("Room is already booked in this period.");
            }

            var roomBookingDto = new RoomBookingModel
            {
                Id = Guid.NewGuid(),
                DirectBookingId = assignRoomDto.DirectBookingId,
                RoomId = assignRoomDto.RoomId,
                RoomRate = assignRoomDto.RoomRate,
            };

            dbContext.RoomBookingsModel.Add(roomBookingDto);
            await dbContext.SaveChangesAsync();

            return Ok("Room assigned successfully.");
        }
    }
    public class AssignRoomDto 
    { 
        public Guid DirectBookingId { get; set; } 
        public Guid RoomId { get; set; }
        public decimal RoomRate { get; set; }
    }
}
