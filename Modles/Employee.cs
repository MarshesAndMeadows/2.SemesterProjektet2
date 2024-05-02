using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public char Sex { get; set; }
        public string WorkPosition { get; set; }
        public DateTime DateHired{ get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
    }
}