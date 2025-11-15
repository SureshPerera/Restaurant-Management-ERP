using API.Model.DTO;
using API.Model.SmartSale_Billing;
using API.Model.UserManagement;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public UserManagementController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.UserManagementModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.UserManagementModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);
        }
        
        [HttpGet("by-nic/{NIC}")]
        public async Task<IActionResult> GetBookingByNIC(string NIC)
        {
            //check Is avalable in db
            var DomainModel = await  dbContext.UserManagementModels.Where(a => a.Email == NIC).FirstOrDefaultAsync();
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserManagementModelDto userManagementModelDto)
        {
            var DomainModel = await dbContext.UserManagementModels.FirstOrDefaultAsync(a => a.NIC == userManagementModelDto.NIC);
            if (DomainModel != null)
            {
                ModelState.AddModelError("NIC No", "The NIC no is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new UserManagementModel
            {
                Id = Guid.NewGuid(),
                NIC = userManagementModelDto.NIC,
                AccessLevel = userManagementModelDto.AccessLevel,
                Address = userManagementModelDto.Address,
                Administration = userManagementModelDto.Administration,
                AssetsManagement = userManagementModelDto.AssetsManagement,
                CheckInOut = userManagementModelDto.CheckInOut,
                ClientManagement = userManagementModelDto.ClientManagement,
                Comment = userManagementModelDto.Comment,
                DashBoard = userManagementModelDto.DashBoard,
                DOB = userManagementModelDto.DOB,
                Email = userManagementModelDto.Email,
                FirstName = userManagementModelDto.FirstName,
                Gender = userManagementModelDto.Gender,
                HouseKeeping = userManagementModelDto.HouseKeeping,
                LastName = userManagementModelDto.LastName,
                PassWord = userManagementModelDto.PassWord,
                PhoneNumber = userManagementModelDto.PhoneNumber,
                Reservation = userManagementModelDto.Reservation,
                StockInventory = userManagementModelDto.StockInventory,
                Inhouse = userManagementModelDto.Inhouse,
                UserManagements = userManagementModelDto.UserManagements,
                SmartSalling = userManagementModelDto.SmartSalling

            };
            await dbContext.UserManagementModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UserManagementModelDto userManagementModelDto)
        {

            var DomainModel = dbContext.UserManagementModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.AccessLevel = userManagementModelDto.AccessLevel;
            DomainModel.LastName = userManagementModelDto.LastName;
            DomainModel.Address = userManagementModelDto.Address;
            DomainModel.PhoneNumber = userManagementModelDto.PhoneNumber;
            DomainModel.Comment = userManagementModelDto.Comment;
            DomainModel.Administration = userManagementModelDto.Administration;
            DomainModel.NIC = userManagementModelDto.NIC;
            DomainModel.AssetsManagement = userManagementModelDto.AssetsManagement;
            DomainModel.CheckInOut = userManagementModelDto.CheckInOut;
            DomainModel.DashBoard = userManagementModelDto.DashBoard;
            DomainModel.DOB = userManagementModelDto.DOB;
            DomainModel.Email = userManagementModelDto.Email;
            DomainModel.FirstName = userManagementModelDto.FirstName;
            DomainModel.PassWord = userManagementModelDto.PassWord;
            DomainModel.HouseKeeping = userManagementModelDto.HouseKeeping;
            DomainModel.UserManagements = userManagementModelDto.UserManagements;
            DomainModel.ClientManagement = userManagementModelDto.ClientManagement;
            DomainModel.Gender = userManagementModelDto.Gender;
            DomainModel.Reservation = userManagementModelDto.Reservation;
            DomainModel.StockInventory = userManagementModelDto.StockInventory;
            DomainModel.Inhouse = userManagementModelDto.Inhouse;
            DomainModel.SmartSalling = userManagementModelDto.SmartSalling;
           

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.UserManagementModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.UserManagementModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.FirstName + " " + "Succusfully Delete");
        }
    }
}
