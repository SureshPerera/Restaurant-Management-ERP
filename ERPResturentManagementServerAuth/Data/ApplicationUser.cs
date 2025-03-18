using ERPResturentManagementServerAuth.Components.Tables;
using Microsoft.AspNetCore.Identity;

namespace ERPResturentManagementServerAuth.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    //public List<Super> Super { get; set; } = new List<Super>();

    //public List<User> User { get; set; } = new List<User>();
    public List<ManagersDetails> ManageDetails { get; set; } = new List<ManagersDetails>();

}

