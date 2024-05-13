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
        public Employee Employee { get; set; }
        [ForeignKey("ClientId")]
        public Client Client { get; set; }
        public List<AppliedService>? AppliedServices { get; set; }
    }
}