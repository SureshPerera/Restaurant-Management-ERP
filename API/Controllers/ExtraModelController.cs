using API.Model.Administration;
using API.Model.DTO;
using API.Model.Reservation;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraModelController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ExtraModelController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.ExRateModel.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.ExRateModel.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ExrateModelDto exrateModelDto)
        {
            var DomainModel = await dbContext.ExRateModel.FirstOrDefaultAsync(a => a.CurrencyName == exrateModelDto.CurrencyName);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Currency Name", "The Currency Name is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new ExRateModel
            {
                Id = Guid.NewGuid(),
                BuyingRate = exrateModelDto.BuyingRate,
                CurrencyName = exrateModelDto.CurrencyName,
                SellingRate = exrateModelDto.SellingRate,
                CreateDate = DateTime.Now,
            };
            await dbContext.ExRateModel.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ExrateModelDto exrateModelDto)
        {

            var DomainModel = dbContext.ExRateModel.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.SellingRate = exrateModelDto.SellingRate;
            DomainModel.CurrencyName = exrateModelDto.CurrencyName;
            DomainModel.BuyingRate = exrateModelDto.BuyingRate;

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id} \n {exrateModelDto.CurrencyName}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.ExRateModel.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.ExRateModel.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.CurrencyName + " " + "Succusfully Delete");
        }
    }
}
