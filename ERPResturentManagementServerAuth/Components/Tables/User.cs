using System.ComponentModel.DataAnnotations;

namespace ERPResturentManagementServerAuth.Components.Tables
{
    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public int PinNumber { get; set; }

    }

}
