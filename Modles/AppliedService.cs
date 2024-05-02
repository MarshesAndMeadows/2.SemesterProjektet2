using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AppliedService
    {
        [Key]
        public int AppliedServiceId { get; set; }
        public string Note { get; set; }
        public int? UnitCount { get; set; }
        public double? UnitCostActual { get; set; }
        public double? StartPaymentActual { get; set; }
        public DateTime ServicePreformed { get; set; }
        // Navigations properties
        public virtual Service Service { get; set; } = new Service();

    }
}