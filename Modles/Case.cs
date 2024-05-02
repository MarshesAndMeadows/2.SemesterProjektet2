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
        public virtual Employee Employee { get; set; }
        public virtual Client Client { get; set; } 
        public virtual List<AppliedService>? AppliedServices { get; set; }
    }
}