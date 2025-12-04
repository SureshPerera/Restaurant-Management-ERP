using API.Model.ClientManagemnet;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResortManagementApp.Models.Auth;
using ResortManagementApp.Models.Auth.AuthDto;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistationController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public RegistationController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegistations()
        {
            var DomainModel = await dbContext.RegistationModel.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.RegistationModel.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpGet]
        [Route("{email}")]
        public async Task<IActionResult> GetBookingByUserName(string email)
        {
           
            var DomainModel = await dbContext.RegistationModel.FirstOrDefaultAsync(a=>a.Email == email);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RegistationDto RegDto)
        {
            //var DomainModel = await dbContext.AdvancePaymentModels.FirstOrDefaultAsync(a => a.DirectBookingId == advancePaymentModel.Id);
            //if (DomainModel != null)
            //{
            //    ModelState.AddModelError("Error", "The Id is already used ");
            //    var validation = new ValidationProblemDetails(ModelState);
            //    return BadRequest(validation);
            //}
            var Dto = new RegistationModel
            {
                AccessLevel = RegDto.AccessLevel,
                Address = RegDto.Address,
                Administration_checkBox = RegDto.Administration_checkBox,
                CheckIn_checkBox = RegDto.CheckIn_checkBox,
                ClientManagement_checkBox = RegDto.ClientManagement_checkBox,
                Comments = RegDto.Comments,
                DashBoard_checkBox = RegDto.DashBoard_checkBox,
                DateOfBirth = RegDto.DateOfBirth,
                Email = RegDto.Email,
                FirstName = RegDto.FirstName,
                Gender = RegDto.Gender,
                HouseKeeping_checkBox = RegDto.HouseKeeping_checkBox,
                Id = Guid.NewGuid(),
                Inhouse_checkBox = RegDto.Inhouse_checkBox,
                LastName = RegDto.LastName,
                Password = RegDto.Password,
                PhoneNumber = RegDto.PhoneNumber,
                Reservations_checkBox = RegDto.Reservations_checkBox,
                SmartSales_checkBox = RegDto.SmartSales_checkBox,
                UserManagement_checkBox = RegDto.UserManagement_checkBox,
                CreateDate = DateTime.Now,
            };
            await dbContext.RegistationModel.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] RegistationDto RegDto)

        {

            var DomainModel = dbContext.RegistationModel.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.PhoneNumber = RegDto.PhoneNumber;
            DomainModel.FirstName = RegDto.FirstName;
            DomainModel.LastName = RegDto.LastName;
            DomainModel.Password = RegDto.Password;
            DomainModel.AccessLevel = RegDto.AccessLevel;
            DomainModel.DateOfBirth = RegDto.DateOfBirth;
            DomainModel.Email = RegDto.Email;
            DomainModel.Address = RegDto.Address;
            DomainModel.Administration_checkBox = RegDto.Administration_checkBox;
            DomainModel.CheckIn_checkBox = RegDto.CheckIn_checkBox;
            DomainModel.Comments = RegDto.Comments;
            DomainModel.DashBoard_checkBox = RegDto.DashBoard_checkBox;
            DomainModel.HouseKeeping_checkBox = RegDto.HouseKeeping_checkBox;
            DomainModel.Inhouse_checkBox = RegDto.Inhouse_checkBox;
            DomainModel.UserManagement_checkBox = RegDto.UserManagement_checkBox;
            DomainModel.SmartSales_checkBox = RegDto.SmartSales_checkBox;
            DomainModel.Reservations_checkBox = RegDto.Reservations_checkBox;


           
            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id},");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.RegistationModel.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.RegistationModel.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.Id + " " + "Succusfully Delete");
        }
    }
}
