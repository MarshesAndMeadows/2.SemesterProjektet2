using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public char Sex { get; set; }
        public string Address { get; set; }
        public string Workposition { get; set; }
        public DateOnly DateHired{ get; set; }
        public string Email { get; set; }

        public string Workphone { get; set; }
        public int Zipcode { get; set; }

        [ForeignKey("Zipcode")]
        public virtual Zipcode ZipcodeInfo { get; set; }
    }
}