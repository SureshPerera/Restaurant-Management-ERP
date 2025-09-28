using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure DbContext properly
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // Make sure your connection string is correct in appsettings.json
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Configure CORS to allow calls from Blazor WebAssembly
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient", policy =>
    {
        policy.WithOrigins("https://localhost:5000") // Replace with your Blazor app URL
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add HttpClient if needed for DI
builder.Services.AddHttpClient();

var app = builder.Build();

// Enable CORS before other middleware
app.UseCors("AllowBlazorClient");

// Use HTTPS
app.UseHttpsRedirection();

app.UseAuthorization();

// Map controller endpoints
app.MapControllers();

app.Run();
