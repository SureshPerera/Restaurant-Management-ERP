using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ResortManagementApp.Pages.OnlineBookingPortal.Crud;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CustomerUsePcInfo? customerUsePcInfo { get; set; }
        public GeoController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet("country")]
        public async Task<IActionResult> GetCountry()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();

                var response = await client.GetAsync("https://ipinfo.io/json");

                if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    return StatusCode(429, "Geo service rate limit exceeded. Please try again later.");
                }

                response.EnsureSuccessStatusCode();

                var result = await response.Content.ReadAsStringAsync();
                
                dynamic? data = JsonConvert.DeserializeObject(result);

               
                var customer = new CustomerUsePcInfo
                {
                    Ip = data?.Ip,
                    Country = data?.country,
                    City = data?.city,
                    Browser = Request.Headers["User-Agent"].ToString()
                };

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error fetching country info: {ex.Message}");
            }
        }
    }
}
