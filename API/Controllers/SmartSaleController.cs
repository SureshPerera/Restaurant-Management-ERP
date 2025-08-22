using API.Model.Administration;
using API.Model.DTO;
using API.Model.SmartSale_Billing;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartSaleController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public SmartSaleController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.SmartSaleModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.SmartSaleModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SmartSaleModelDto smartSaleModelDto)
        {
            var DomainModel = await dbContext.SmartSaleModels.FirstOrDefaultAsync(a => a.Id == smartSaleModelDto.Id);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Room No", "The Room no is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new SmartSaleModel
            {
                Id = Guid.NewGuid(),
                Discouunt = smartSaleModelDto.Discouunt,
                Quantity = smartSaleModelDto.Quantity,
                Remark = smartSaleModelDto.Remark,
                SandryItem = smartSaleModelDto.SandryItem,
                TotalLKR = smartSaleModelDto.UnitPrice * smartSaleModelDto.Quantity - smartSaleModelDto.Discouunt,
                UnitPrice = smartSaleModelDto.UnitPrice,
                
            };
            await dbContext.SmartSaleModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] SmartSaleModelDto smartSaleModelDto)
        {

            var DomainModel = dbContext.SmartSaleModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.SandryItem = smartSaleModelDto.SandryItem;
            DomainModel.Quantity = smartSaleModelDto.Quantity;
            DomainModel.Discouunt = smartSaleModelDto.Discouunt;
            DomainModel.TotalLKR = smartSaleModelDto.Quantity * smartSaleModelDto.UnitPrice - smartSaleModelDto.Discouunt;
            DomainModel.UnitPrice = smartSaleModelDto.UnitPrice; 
            DomainModel.Remark = smartSaleModelDto.Remark;

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.SmartSaleModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.SmartSaleModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.Id + " " + "Succusfully Delete");
        }
    }
}
