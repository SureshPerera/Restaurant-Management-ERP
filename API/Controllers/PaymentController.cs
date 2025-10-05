using API.Model.Payment;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResortManagementApp.Pages.Payment;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public PaymentController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost("Checkout")]
        public async Task<IActionResult> Checkout([FromBody] PaymentRequest req)
        {
            // basic validation
            if (req == null || req.Amount <= 0) return BadRequest("Invalid payment");

            // ensure booking exists (optional)
            var bookingExists = await dbContext.RoomBookingsModel.AnyAsync(rb => rb.Id == req.BookingId);
            if (!bookingExists) return NotFound("Booking or room booking not found");

            var payment = new PaymentModel
            {
                BookingId = req.BookingId,
                Amount = req.Amount,
                Currency = req.Currency ?? "LKR",
                PaymentMethod = req.PaymentMethod!,
                TransactionId = req.TransactionId,
                Status = "Completed",
                Notes = req.Notes,
                PaymentDate = DateTime.UtcNow
            };

            dbContext.PaymentModel.Add(payment);
            await dbContext.SaveChangesAsync();

            // mark booking as paid / update balance, or create receipt record, etc.

            return Ok(payment);
        }
        public class PaymentRequest
        {
            public Guid BookingId { get; set; }
            public decimal Amount { get; set; }
            public string? Currency { get; set; }
            public string? PaymentMethod { get; set; }
            public string? TransactionId { get; set; }
            public string? Notes { get; set; }
        }
    }
}
