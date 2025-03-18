using Duende.IdentityServer.EntityFramework.Options;
using ERPResturentManagementServerAuth.Components.Tables;
using ERPResturentManagementServerAuth.Migrations;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Options;

namespace ERPResturentManagementServerAuth.Data;

public class ApplicationDbContext : /*DbContext*/ ApiAuthorizationDbContext<ApplicationUser>
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
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    modelBuilder.Entity<Components.Tables.Dealer>()
    //        .HasKey(d => d.Id); // Ensure DealerId is the primary key
    //}

    //public DbSet<Components.Tables.Super> Super => Set<Components.Tables.Super>();
    public DbSet<Components.Tables.ManagersDetails> ManagersDetails { get; set; }

}
