using API.Model.Administration;
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
    public class AgentController : ControllerBase
    {

        private readonly ApplicationDbContext dbContext;

        public AgentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.AgentModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.AgentModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AgentModelDto agentModelDto)
        {
            var DomainModel = await dbContext.AgentModels.FirstOrDefaultAsync(a => a.Email == agentModelDto.Email);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Email", "The Email is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new AgentModel
            {
                Id = Guid.NewGuid(),
                AgentName = agentModelDto.AgentName,
                Email = agentModelDto.Email,
                CreditLimit = agentModelDto.CreditLimit,
                AgentAddress = agentModelDto.AgentAddress,
                ContactPerson = agentModelDto.ContactPerson,
                Fax = agentModelDto.Fax,
                Mobile = agentModelDto.Mobile,
                VatRegNo = agentModelDto.VatRegNo,
                WebSite = agentModelDto.WebSite,
                NIC = agentModelDto.NIC,
                
            };
            //var Dtos = new ClientModel
            //{
            //    FirstName = agentModelDto.AgentName,
            //    PhoneNumber = agentModelDto.Mobile,
            //    Address = agentModelDto.AgentAddress,
            //    EmailAddress = agentModelDto.Email,
            //    NIC = agentModelDto.NIC,
            //    CreditLimit = agentModelDto.CreditLimit,
            //};

            await dbContext.AgentModels.AddAsync(Dto);
            //await dbContext.ClientModels.AddAsync(Dtos);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] AgentModelDto agentModelDto)
        {

            var DomainModel = dbContext.AgentModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.WebSite = agentModelDto.WebSite;
            DomainModel.Email = agentModelDto.Email;
            DomainModel.AgentAddress = agentModelDto.AgentAddress;
            DomainModel.AgentName = agentModelDto.AgentName;
            DomainModel.VatRegNo = agentModelDto.VatRegNo;
            DomainModel.ContactPerson = agentModelDto.ContactPerson;
            DomainModel.CreditLimit = agentModelDto.CreditLimit;
            DomainModel.Fax = agentModelDto.Fax;
            DomainModel.Mobile = agentModelDto.Mobile;

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}, FirstName: {agentModelDto.AgentName}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.AgentModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.AgentModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.AgentName + " " + "Succusfully Delete");
        }
    }
}
