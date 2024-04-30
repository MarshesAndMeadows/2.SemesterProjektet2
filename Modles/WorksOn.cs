using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class WorksOn
    {
        [Key]
        public int WorksOnId { get; set; }
        public string Note { get; set; }
        public int? UnitCount { get; set; }
        public double? UnitCostActual { get; set; }
        public double? StartPaymentActual { get; set; }
        public DateTime ServicePreformed { get; set; }
        // Navigations properties
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; } = new Service();
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } = new Employee();
        [ForeignKey("CaseId")]
        public virtual Case Case { get; set; } = new Case();
    }
}