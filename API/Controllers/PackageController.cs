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
    public class PackageController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public PackageController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var DomainModel = await dbContext.PackageModels.ToListAsync();
            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById(Guid id)
        {
            //check Is avalable in db
            var DomainModel = await dbContext.PackageModels.FindAsync(id);
            if (DomainModel == null) { return NotFound(); }
            return Ok(DomainModel);

        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PackageModelDto packageModelDto)
        {
            var DomainModel = await dbContext.PackageModels.FirstOrDefaultAsync(a => a.PackageName == packageModelDto.PackageName);
            if (DomainModel != null)
            {
                ModelState.AddModelError("Name", "The Name is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new PackageModel
            {
                Id = Guid.NewGuid(),
                AccomadationType = packageModelDto.AccomadationType,
                Basis = packageModelDto.Basis,
                Entitlemeal1 = packageModelDto.Entitlemeal1,
                Entitlemeal2 = packageModelDto.Entitlemeal2,
                Entitlemeal3 = packageModelDto.Entitlemeal3,
                Entitlemeal4 = packageModelDto.Entitlemeal4,
                PackageDetails = packageModelDto.PackageDetails,
                PackageName = packageModelDto.PackageName,
                RoomRateAutumn = packageModelDto.RoomRateAutumn,
                RoomRateSpring = packageModelDto.RoomRateSpring,
                RoomRateSummer = packageModelDto.RoomRateSummer,
                RoomRateWinter = packageModelDto.RoomRateWinter,
                RoomType = packageModelDto.RoomType,
                SpecialPackage1 = packageModelDto.SpecialPackage1,
                SpecialPackage2 = packageModelDto.SpecialPackage2,
                SpecialPackage3 = packageModelDto.SpecialPackage3,
                SpecialPackage4 = packageModelDto.SpecialPackage4,
                CreateDate = DateTime.Now,


            };
            await dbContext.PackageModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] PackageModelDto  packageModelDto)
        {

            var DomainModel = dbContext.PackageModels.Find(id);
            if (DomainModel == null) { return NotFound(); }

            DomainModel.Entitlemeal1 = packageModelDto.Entitlemeal1;
            DomainModel.Entitlemeal2 = packageModelDto.Entitlemeal2;
            DomainModel.Entitlemeal4 = packageModelDto.Entitlemeal4;
            DomainModel.Entitlemeal3  = packageModelDto.Entitlemeal3;
            DomainModel.SpecialPackage1 = packageModelDto.SpecialPackage1;
            DomainModel.SpecialPackage3 = packageModelDto.SpecialPackage3;
            DomainModel.SpecialPackage2  = packageModelDto.SpecialPackage2;
            DomainModel.SpecialPackage4 = packageModelDto.SpecialPackage4;
            DomainModel.AccomadationType = packageModelDto.AccomadationType;
            DomainModel.Basis = packageModelDto.Basis;
            DomainModel.PackageDetails = packageModelDto.PackageDetails;
            DomainModel.PackageName = packageModelDto.PackageName;
            DomainModel.RoomRateAutumn = packageModelDto.RoomRateAutumn;
            DomainModel.RoomRateSpring = packageModelDto.RoomRateSpring;
            DomainModel.RoomRateSummer = packageModelDto.RoomRateSummer;    
            DomainModel.RoomRateWinter = packageModelDto.RoomRateWinter;



            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}");
            return Ok(DomainModel);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.PackageModels.Find(id);
            if (domainModel == null) { return NotFound(); }
            dbContext.PackageModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.Id + " " + "Succusfully Delete");
        }
    }
}
