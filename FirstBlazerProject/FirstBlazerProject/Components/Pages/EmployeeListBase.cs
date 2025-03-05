using EmployeeManagementModel;
using Microsoft.AspNetCore.Components;

namespace FirstBlazerProject.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
                
        }
        public void LoadEmployees()
        {
            
            Employee e1 = new Employee
            {
                EmpId = 1,
                FName = "Sunimal",
                Lname = "Gmage",
                Email = "sunilgamage@gmail.com",
                DOB = new DateTime(1852, 02, 05),
                Gender = Gender.Male,
                Dep = new Department { DepId = 001, DepName = "LCS" },
                photoPath = "asdasdasda"
            };
            Employee e2 = new Employee
            {
                EmpId = 1,
                FName = "Sunimal",
                Lname = "Gmage",
                Email = "sunilgamage@gmail.com",
                DOB = new DateTime(1852, 02, 05),
                Gender = Gender.Male,
                Dep = new Department { DepId = 001, DepName = "LCS" },
                photoPath = "asdasdasda"
            };
            Employee e3 = new Employee
            {
                EmpId = 1,
                FName = "Sunimal",
                Lname = "Gmage",
                Email = "sunilgamage@gmail.com",
                DOB = new DateTime(1852, 02, 05),
                Gender = Gender.Male,
                Dep = new Department { DepId = 001, DepName = "LCS" },
                photoPath = "asdasdasda"
            };
            Employee e4 = new Employee
            {
                EmpId = 1,
                FName = "Sunimal",
                Lname = "Gmage",
                Email = "sunilgamage@gmail.com",
                DOB = new DateTime(1852, 02, 05),
                Gender = Gender.Male,
                Dep = new Department { DepId = 001, DepName = "LCS" },
                photoPath = "asdasdasda"
            };
            Employee e5 = new Employee
            {
                EmpId = 1,
                FName = "Sunimal",
                Lname = "Gmage",
                Email = "sunilgamage@gmail.com",
                DOB = new DateTime(1852, 02, 05),
                Gender = Gender.Male,
                Dep = new Department { DepId = 001, DepName = "LCS" },
                photoPath = "asdasdasda"
            };
            Employees = new List<Employee> { e1, e2, e3, e4, e5 };

        }
    }

}


