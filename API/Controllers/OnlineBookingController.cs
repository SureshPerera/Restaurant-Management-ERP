using API.Model.ClientManagemnet;
using API.Model.DTO;
using API.Model.Reservation.OnlineBooking;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineBookingController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
       
        

        public OnlineBookingController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
           
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel =await dbContext.OnlineBookingModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.OnlineBookingModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OnlineBookingModelDto onlineBookingModelDto)
        {
            var DomainModel = await dbContext.OnlineBookingModels.FirstOrDefaultAsync(a => a.NIC == onlineBookingModelDto.NIC);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Email", "The NIC is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new OnlineBookingModel
            {
                Id = Guid.NewGuid(),
                FirstName = onlineBookingModelDto.FirstName,
                LastName = onlineBookingModelDto.LastName,
                PhoneNumber = onlineBookingModelDto.PhoneNumber,
                DathOfBirth = onlineBookingModelDto.DathOfBirth,
                EmailAddress = onlineBookingModelDto.EmailAddress,
                NIC = onlineBookingModelDto.NIC,
                CreditLimit = onlineBookingModelDto.CreditLimit,
                OpeningBalanace = onlineBookingModelDto.OpeningBalanace,
                Nationality = onlineBookingModelDto.Nationality,
                Remark = onlineBookingModelDto.Remark,
                Address = onlineBookingModelDto.Address,
                CustomerType = onlineBookingModelDto.CustomerType,
                CheckInDate = onlineBookingModelDto.CheckInDate,
                CheckOutDate = onlineBookingModelDto.CheckOutDate,
                NoOfAdults = onlineBookingModelDto.NoOfAdults,
                NoOfChildren = onlineBookingModelDto.NoOfChildren,
                NoOfRooms = onlineBookingModelDto.NoOfRooms,
                PramoCode = onlineBookingModelDto.PramoCode
                
                
            };
            var Dtos = new ClientModel
            {
                FirstName = onlineBookingModelDto.FirstName,
                LastName = onlineBookingModelDto.LastName,
                PhoneNumber = onlineBookingModelDto.PhoneNumber,
                DathOfBirth = onlineBookingModelDto.DathOfBirth,
                Address = onlineBookingModelDto.Address,
                EmailAddress = onlineBookingModelDto.EmailAddress,
                NIC = onlineBookingModelDto.NIC,
                CreditLimit = onlineBookingModelDto.CreditLimit,
                OpeningBalanace = onlineBookingModelDto.OpeningBalanace,
                Nationality = onlineBookingModelDto.Nationality,
                Remark = onlineBookingModelDto.Remark,
            };
            await dbContext.OnlineBookingModels.AddAsync(Dto);
            await dbContext.ClientModels.AddAsync(Dtos);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] OnlineBookingModelDto onlineBookingModelDto)
        {
           
            var DomainModel = dbContext.OnlineBookingModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.FirstName = onlineBookingModelDto.FirstName;
            DomainModel.LastName = onlineBookingModelDto.LastName;
            DomainModel.PhoneNumber = onlineBookingModelDto.PhoneNumber;
            DomainModel.DathOfBirth = onlineBookingModelDto.DathOfBirth;
            DomainModel.Address = onlineBookingModelDto.Address;
            DomainModel.EmailAddress = onlineBookingModelDto.EmailAddress;
            DomainModel.NIC = onlineBookingModelDto.NIC;
            DomainModel.CreditLimit = onlineBookingModelDto.CreditLimit;
            DomainModel.OpeningBalanace = onlineBookingModelDto.OpeningBalanace;
            DomainModel.Nationality = onlineBookingModelDto.Nationality;
            DomainModel.Remark = onlineBookingModelDto.Remark;
            DomainModel.CustomerType = onlineBookingModelDto.CustomerType;
            DomainModel.CheckOutDate = onlineBookingModelDto.CheckOutDate;
            DomainModel.CheckInDate = onlineBookingModelDto.CheckInDate;
            DomainModel.NoOfAdults = onlineBookingModelDto.NoOfAdults;
            DomainModel.NoOfRooms = onlineBookingModelDto.NoOfRooms;
            DomainModel.NoOfChildren = onlineBookingModelDto.NoOfChildren;
            DomainModel.PramoCode = onlineBookingModelDto.PramoCode;

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}, FirstName: {onlineBookingModelDto.FirstName}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.OnlineBookingModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.OnlineBookingModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.FirstName + " " + "Succusfully Delete");
        }
        [HttpPut("{id}/confirm")]
        public async Task<IActionResult> ConfirmDirectBooking(Guid id)
        {
            try
            {
                var booking = await dbContext.OnlineBookingModels.FindAsync(id);
                if (booking == null)
                {
                    return NotFound(new { message = $"Booking with ID {id} not found" });
                }

                booking.Conformation = true;
                await dbContext.SaveChangesAsync();

                return Ok(new
                {
                    message = "Booking confirmed successfully",
                    bookingId = id,
                    confirmation = true
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"Error confirming booking: {ex.Message}" });
            }
        }
        [HttpPut("{id}/unconfirm")]
        public async Task<IActionResult> UnconfirmDirectBooking(Guid id)
        {
            try
            {
                var booking = await dbContext.OnlineBookingModels.FindAsync(id);
                if (booking == null)
                {
                    return NotFound(new { message = $"Booking with ID {id} not found" });
                }

                booking.Conformation = false;
                await dbContext.SaveChangesAsync();

                return Ok(new
                {
                    message = "Booking Unconfirmed successfully",
                    bookingId = id,
                    confirmation = false
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"Error Unconfirmed booking: {ex.Message}" });
            }
        }
    }
}
