using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Lawyer : Employee
    {
        public Lawyer()
        {
            Educations = new List<Education>();
            AppliedServices = new List<AppliedService>();
        }

        public List<AppliedService> AppliedServices { get; set; }
        public List<Education> Educations { get; set; }
    }
}