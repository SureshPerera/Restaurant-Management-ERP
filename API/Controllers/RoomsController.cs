using API.Model.Administration;
using API.Model.DTO;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public RoomsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.RoomModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.RoomModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RoomModelDto roomModelDto)
        {
            var DomainModel = await dbContext.RoomModels.FirstOrDefaultAsync(a => a.RoomId == roomModelDto.RoomId);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Room No", "The Room no is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new RoomModel
            {
                Id = Guid.NewGuid(),
                RoomId = roomModelDto.RoomId,
                AdditionalDetails = roomModelDto.AdditionalDetails,
                LastCleanedBy = roomModelDto.LastCleanedBy,
                LastCleanedDate = roomModelDto.LastCleanedDate,
                MaintainStatus = roomModelDto.MaintainStatus,
                MaintenanceComment = roomModelDto.MaintenanceComment,
                MaximumOccupancy = roomModelDto.MaximumOccupancy,
                RoomDisplayTitle = roomModelDto.RoomDisplayTitle,
                RoomStatus = roomModelDto.RoomStatus,
                RoomFloor = roomModelDto.RoomFloor,
                RoomType = roomModelDto.RoomType,
                CreateDate = DateTime.Now,
            };
            await dbContext.RoomModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] RoomModelDto roomModelDto)
        {

            var DomainModel = await dbContext.RoomModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            DomainModel.RoomFloor = roomModelDto.RoomFloor;
            DomainModel.AdditionalDetails = roomModelDto.AdditionalDetails;
            DomainModel.RoomDisplayTitle = roomModelDto.RoomDisplayTitle;
            DomainModel.RoomStatus = roomModelDto.RoomStatus;
            DomainModel.LastCleanedDate = roomModelDto.LastCleanedDate;
            DomainModel.LastCleanedBy = roomModelDto.LastCleanedBy;
            DomainModel.RoomId = roomModelDto.RoomId;
            DomainModel.MaintainStatus = roomModelDto.MaintainStatus;
            DomainModel.MaintenanceComment = roomModelDto.MaintenanceComment;
            DomainModel.MaximumOccupancy = roomModelDto.MaximumOccupancy;
            DomainModel.RoomType = roomModelDto.RoomType;
            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.RoomModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.RoomModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.Id + " " + "Succusfully Delete");
        }
    }
}
