using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Case
    {
        [Key]
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public bool CaseClosed { get; set; }
        // Navigations properties
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } = new Employee();
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; } = new Client();
        [ForeignKey("WorksOnId")]
        public virtual List<WorksOn> WorkOn { get; set; } = new List<WorksOn>();
    }
}