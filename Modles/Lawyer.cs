using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Lawyer : Employee
    {
        [Key]
        public int CaseId { get; set; }
        [ForeignKey("CaseId")]
        public virtual Case Case { get; set; }

        public string SpecializedEducation { get; set; }
    }
}