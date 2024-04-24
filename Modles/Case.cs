using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Case
    {
        [Key]
        public int CaseId { get; set; }

        public string Name { get; set; }

        public DateOnly EstimatedEndDate { get; set; }

        public DateOnly StartDate { get; set; }

        public bool CaseClosed { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }

        public virtual List<CaseService> CaseServices { get; set; }
    }
}