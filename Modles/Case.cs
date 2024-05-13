using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Case
    {
        [Key]
        public int Id { get; set; }
        public string CaseName { get; set; }
        public string CaseDescription { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool CaseClosed { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public virtual List<AppliedService>? AppliedServices { get; set; }
    }
}