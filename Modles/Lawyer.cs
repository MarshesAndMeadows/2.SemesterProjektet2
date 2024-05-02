using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Lawyer : Employee
    {
        public virtual List<AppliedService>? AppliedServices { get; set; }
        public virtual List<Education>? Educations { get; set; }
    }
}