using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Case
    {
        [Key]
        public int CaseId { get; set; }

        public string Name { get; set; }

        public DateTime EstimatedEndDate { get; set; }

        public DateTime StartDate { get; set; }

        public bool CaseClosed { get; set; }

        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public virtual Client Client { get; set; }
    }
}