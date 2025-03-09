using ERPResturentManagementServerAuth.Components.Tables;
using Microsoft.AspNetCore.Identity;

namespace ERPResturentManagementServerAuth.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<CustomerDetails> CustomerDetails { get; set; } = new List<CustomerDetails>();
    public List<Super> Super { get; set; } = new List<Super>();
}

