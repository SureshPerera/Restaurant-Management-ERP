﻿using API.Model.DTO;
using API.Model.Reservation;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectBookingController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public DirectBookingController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //GET: api/DirectBookingController/GetAll
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //Domain model to Dto
            var DomainModel =await dbContext.DirectBookingModels.ToListAsync();

            return Ok(DomainModel);
        }
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetBookingById( Guid id)
        {
            //check Is avalable in db
            var DirectBookingDomainModel = await dbContext.DirectBookingModels.FindAsync(id);
            if(DirectBookingDomainModel == null) { return NotFound(); }
            return Ok(DirectBookingDomainModel);
            
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DirectBookingDTO directBookingDTO)
        {
            var DomainModel = await dbContext.DirectBookingModels.FirstOrDefaultAsync(a => a.NIC == directBookingDTO.NIC);
            if(DomainModel != null)
            {
                ModelState.AddModelError("Email", "The NIC is already used ");
                var validation = new ValidationProblemDetails(ModelState);
                return BadRequest(validation);
            }
            var Dto = new DirectBookingModel
            {
                FirstName = directBookingDTO.FirstName,
                LastName = directBookingDTO.LastName,
                PhoneNumber = directBookingDTO.PhoneNumber,
                DathOfBirth = directBookingDTO.DathOfBirth,
                Address = directBookingDTO.Address,
                EmailAddress = directBookingDTO.EmailAddress,
                NIC = directBookingDTO.NIC,
                CreditLimit = directBookingDTO.CreditLimit,
                OpeningBalanace = directBookingDTO.OpeningBalanace,
                Nationality = directBookingDTO.Nationality,
                Remark = directBookingDTO.Remark,
            };
            await dbContext.DirectBookingModels.AddAsync(Dto);
            await dbContext.SaveChangesAsync();
            return Ok(Dto);

        }
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] DirectBookingDTO directBookingDTO)
        {
            //var DomainModel = dbContext.DirectBookingModels.Find(id);
            //if (DomainModel != null)
            //{
            //    ModelState.AddModelError("NIC", "The NIC Alredy Used");
            //    var validate = new ValidationProblemDetails(ModelState);
            //    return BadRequest(validate);
            //}
            var exsistingModel = dbContext.DirectBookingModels.Find(id);
            if(exsistingModel == null) { return NotFound(); }

            exsistingModel.FirstName = directBookingDTO.FirstName;
            exsistingModel.LastName = directBookingDTO.LastName;
            exsistingModel.PhoneNumber = directBookingDTO.PhoneNumber;
            exsistingModel.DathOfBirth = directBookingDTO.DathOfBirth;
            exsistingModel.Address = directBookingDTO.Address;
            exsistingModel.EmailAddress = directBookingDTO.EmailAddress;
            exsistingModel.NIC = directBookingDTO.NIC;
            exsistingModel.CreditLimit = directBookingDTO.CreditLimit;
            exsistingModel.OpeningBalanace = directBookingDTO.OpeningBalanace;
            exsistingModel.Nationality = directBookingDTO.Nationality;
            exsistingModel.Remark = directBookingDTO.Remark;

            await dbContext.SaveChangesAsync();
            Console.WriteLine($"Received Update for ID: {id}, FirstName: {directBookingDTO.FirstName}");
            return Ok(exsistingModel);
        }
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var domainModel = dbContext.DirectBookingModels.Find(id);
            if(domainModel == null) { return NotFound(); }
            dbContext.DirectBookingModels.Remove(domainModel);
            await dbContext.SaveChangesAsync();
            return Ok(domainModel.FirstName+" "+"Succusfully Delete");
        }
    }
}
