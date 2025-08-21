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
    public class ExtraChargeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ExtraChargeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.ExtraChargeModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.ExtraChargeModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ExtraChargeModelDto extraChargeModelDto)
        {
            var DomainModel = await dbContext.ExtraChargeModels.FirstOrDefaultAsync(a => a.Id == extraChargeModelDto.Id);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Id", "The Id is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new ExtraChargeModel
            {
                Id = Guid.NewGuid(),
                Amount = extraChargeModelDto.Amount,
                Comment = extraChargeModelDto.Comment,  
                Details = extraChargeModelDto.Details,  
                ExtraChargeType = extraChargeModelDto.ExtraChargeType,
                RateLKR = extraChargeModelDto.RateLKR,
                RateUSD = extraChargeModelDto.RateUSD,
               

            };
            await dbContext.ExtraChargeModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ExtraChargeModel extraChargeModel)
        {

            var DomainModel = dbContext.ExtraChargeModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.RateLKR = extraChargeModel.RateLKR;
            DomainModel.Amount = extraChargeModel.Amount;
            DomainModel.RateUSD = extraChargeModel.RateUSD;
            DomainModel.Details = extraChargeModel.Details;
            DomainModel.Comment = extraChargeModel.Comment; 
            DomainModel.ExtraChargeType = extraChargeModel.ExtraChargeType;
            

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.ExtraChargeModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.ExtraChargeModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.Id + " " + "Succusfully Delete");
        }
    }
}
