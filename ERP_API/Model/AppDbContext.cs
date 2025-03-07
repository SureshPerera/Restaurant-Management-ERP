using EmployeeManagementModel;
using Microsoft.EntityFrameworkCore;

namespace ERP_API.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Depatments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Department>().HasData(
                new Department { DepId = 1, DepName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepId = 2, DepName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepId = 3, DepName = "IS" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepId = 4, DepName = "Secience" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmpId = 1,
                    FName = "Sunimal",
                    Lname = "Gmage",
                    Email = "sunilgamage@gmail.com",
                    DOB = new DateTime(1852, 02, 05),
                    Gender = Gender.Male,
                    Dep = new Department { DepId = 001, DepName = "LCS" },
                    photoPath = "asdasdasda"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmpId = 2,
                    FName = "Sunimal",
                    Lname = "Gmage",
                    Email = "sunilgamage@gmail.com",
                    DOB = new DateTime(1852, 02, 05),
                    Gender = Gender.Male,
                    Dep = new Department { DepId = 001, DepName = "LCS" },
                    photoPath = "asdasdasda"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmpId = 3,
                    FName = "Sunimal",
                    Lname = "Gmage",
                    Email = "sunilgamage@gmail.com",
                    DOB = new DateTime(1852, 02, 05),
                    Gender = Gender.Male,
                    Dep = new Department { DepId = 001, DepName = "LCS" },
                    photoPath = "asdasdasda"
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmpId = 4,
                    FName = "Sunimal",
                    Lname = "Gmage",
                    Email = "sunilgamage@gmail.com",
                    DOB = new DateTime(1852, 02, 05),
                    Gender = Gender.Male,
                    Dep = new Department { DepId = 001, DepName = "LCS" },
                    photoPath = "asdasdasda"
                });
        }
    }
}
