using API.Model.ClientManagemnet;
using API.Model.DTO;
using API.Model.Reservation.OnlineBooking;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancePaymentController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public AdvancePaymentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
         
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.AdvancePaymentModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.AdvancePaymentModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AdvancePaymentModel advancePaymentModel)
        {
            //var DomainModel = await dbContext.AdvancePaymentModels.FirstOrDefaultAsync(a => a.DirectBookingId == advancePaymentModel.Id);
            //if (DomainModel != null)
            //{
            //    ModelState.AddModelError("Error", "The Id is already used ");
            //    var validation = new ValidationProblemDetails(ModelState);
            //    return BadRequest(validation);
            //}
            var Dto = new AdvancePaymentModel
            {
                Id = Guid.NewGuid(),
                Details = advancePaymentModel.Details,
                OderDate = DateTime.UtcNow,
                OderType = advancePaymentModel.OderType,
                PayingAmount = advancePaymentModel.PayingAmount,
                PaymentType = advancePaymentModel.PaymentType,
                DirectBookingId = advancePaymentModel.DirectBookingId,
                CreateDate = DateTime.Now
                
            };
            await dbContext.AdvancePaymentModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] AdvancePaymentModel advancePaymentModel)
        {

            var DomainModel = dbContext.AdvancePaymentModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.OderDate = DomainModel.OderDate;
            DomainModel.OderType = advancePaymentModel.OderType;
            DomainModel.PaymentType = advancePaymentModel.PaymentType;
            DomainModel.Details = advancePaymentModel.Details;
            DomainModel.PayingAmount = advancePaymentModel.PayingAmount;
            DomainModel.DirectBookingId = advancePaymentModel.DirectBookingId;

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id},");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.AdvancePaymentModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.AdvancePaymentModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.Id + " " + "Succusfully Delete");
        }
    }
}
