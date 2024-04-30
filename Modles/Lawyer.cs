using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Lawyer : Employee
    {
        [ForeignKey("CaseId")]
        public virtual List<Case> Cases { get; set; } = new List<Case>();
        [ForeignKey("EducationId")]
        public virtual List<Education> Educations { get; set; } = new List<Education>();
    }
}