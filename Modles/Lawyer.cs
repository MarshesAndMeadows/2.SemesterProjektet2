using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Lawyer : Employee
    {
        [Key]
        public virtual List<Case> Cases { get; set; }
        public string SpecializedEducation { get; set; }
    }
}