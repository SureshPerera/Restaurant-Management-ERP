using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementModel
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FName { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public Department Dep { get; set; }
        public string photoPath { get; set; }

        public void empList()
        {
            List<string> emp = new List<string>
            {
                "suresh",
                "gamage",
                "balasuriya"
            };
        }
    }
}
