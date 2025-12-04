using API.Model.Administration;
using API.Model.Auth;
using API.Model.DTO;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
      

        public UserLoginDetailsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
          
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.UserLoginDetails.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetUserDetailsById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.UserLoginDetails.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserLoginDetails agentModelDto)
        {
            var DomainModel = await dbContext.UserLoginDetails.ToListAsync();
            if (DomainModel == null)
            {
                Console.Write("Null");
            }

            var Dto = new UserLoginDetails
            {
                Id = Guid.NewGuid(),
                IpAddress = agentModelDto.IpAddress,
                IsLoging = true,
                LogingTime = DateTime.Now,
                UserName = agentModelDto.UserName,
               
            };

            await dbContext.UserLoginDetails.AddAsync(Dto);
   
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UserLoginDetails agentModelDto)
        {

            var DomainModel = await dbContext.UserLoginDetails.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            DomainModel.IsLoging = agentModelDto.IsLoging;
           
            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}");
            return Ok(DomainModel);
        }
    }
}
