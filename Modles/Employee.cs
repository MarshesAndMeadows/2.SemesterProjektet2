using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Workposition { get; set; }

        public string Email { get; set; }

        public string Workphone { get; set; }
    }
}