using Duende.IdentityServer.EntityFramework.Options;
using ERPResturentManagementServerAuth.Components.Tables;
using ERPResturentManagementServerAuth.Migrations;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ERPResturentManagementServerAuth.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{
    public ApplicationDbContext(
        DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {
    }
    //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    //: base(options)
    //{
    //}

    public DbSet<Components.Tables.Super> Super => Set<Components.Tables.Super>();
    

} 
