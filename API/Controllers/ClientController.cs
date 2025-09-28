using API.Model.Administration;
using API.Model.ClientManagemnet;
using API.Model.DTO;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ApplicationDbContext dbContext = context;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.ClientModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.ClientModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ClientModelDto clientModelDto)
        {
            var DomainModel = await dbContext.ClientModels.FirstOrDefaultAsync(a => a.EmailAddress == clientModelDto.EmailAddress);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Email", "The Email is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new ClientModel
            {
                Id = new Guid(),
                EmailAddress = clientModelDto.EmailAddress,
                Address = clientModelDto.Address,
                CreditLimit = clientModelDto.CreditLimit,
                CustomerType = clientModelDto.CustomerType,
                DathOfBirth = clientModelDto.DathOfBirth,
                FirstName = clientModelDto.FirstName,
                LastName = clientModelDto.LastName,
                Nationality = clientModelDto.Nationality,
                NIC = clientModelDto.NIC,
                OpeningBalanace = clientModelDto.OpeningBalanace,
                PhoneNumber = clientModelDto.PhoneNumber,
                Remark = clientModelDto.Remark

            };
            await dbContext.ClientModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] ClientModelDto clientModelDto)
        {

            var DomainModel = dbContext.ClientModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.PhoneNumber = clientModelDto.PhoneNumber ?? "";
            DomainModel.LastName = clientModelDto.LastName ?? "";
            DomainModel.FirstName = clientModelDto.FirstName ?? "";
            DomainModel.Address = clientModelDto.Address ?? "";
            DomainModel.NIC = clientModelDto.NIC ?? "";
            DomainModel.DathOfBirth = clientModelDto.DathOfBirth ;
            DomainModel.CreditLimit = clientModelDto.CreditLimit ?? 0;
            DomainModel.CustomerType = clientModelDto.CustomerType ?? "";
            DomainModel.EmailAddress = clientModelDto.EmailAddress ?? "";
            DomainModel.Nationality = clientModelDto.Nationality ?? "";
            DomainModel.OpeningBalanace = clientModelDto.OpeningBalanace ?? 0;
            DomainModel.Remark = clientModelDto.Remark ?? "";

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}, FirstName: {clientModelDto.FirstName}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.ClientModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.ClientModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.FirstName + " " + "Succusfully Delete");
        }
    }
}
